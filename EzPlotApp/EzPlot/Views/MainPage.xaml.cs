using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using EzPlot.Models;
using System.IO;
using System.Collections.ObjectModel;
using EzPlot.Controls;
using System.ComponentModel;

namespace EzPlot.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class MainPage : Page , INotifyPropertyChanged
    {
        private bool isPlacingMarker = false;
        private bool isRemovingMarker = false;
        private bool isAddingMarker = false;
        private bool awaitingClick = false;
        public event EventHandler LeftButton_Pressed;
        public event EventHandler<MarkerEventArgs> MarkerAdded;
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Resident> UnassignedResidents { get; set; }
        public ObservableCollection<Plot> UnassignedPlots { get; set; }
        public ObservableCollection<Resident> Residents { get; set; }
        public ObservableCollection<Cemetery> Cemetaries { get; set; } 
        
        public BitmapImage image { get; set; }
        public ObservableCollection<Plot> Markers { get; set; }
        public Marker CemeteryMarker { get; set; }
        public Plot Plot { get; set; }
        
        private PlotBook selectedPlotBook;
        public PlotBook SelectedPlotBook
        {
            get { return selectedPlotBook; }
            set { if (selectedPlotBook != value)
                {
                    selectedPlotBook = value;
                    OnPropertyChanged(nameof(SelectedPlotBook));
                }
}
        }
        public MainPage()

        {
            using var db = new MYDBContext();
            Markers = new ObservableCollection<Plot>(db.Plots);
            selectedPlotBook = App.SelectedPlotBook;
            InitializeComponent();
            this.DataContext = this;

            if (selectedPlotBook == null) { mapImage.Source = App.defaultImage;}
            else { mapImage.Source = ConvertByteArrayToBitmapImage(App.SelectedPlotBook.image) ; }
            markerToolBoxControl.PlaceMarkerModeActivated += ToolBox_PlacingMarkerModeActivated;
            markerToolBoxControl.RemoveMarkerModeActivated += ToolBox_RemoveMarkerModeDeactivated;
            MarkerAdded += OpenMarkerPopup;
        
           

            
            UnassignedResidents = new ObservableCollection<Resident>(db.Residents.Where(r => r.AssignedToPlot == false));
            
            Cemetaries = new ObservableCollection<Cemetery>(db.Cemeteries);
            
            DrawMarker();

            
        }
        
        private void ToolBox_PlacingMarkerModeActivated(object sender, EventArgs e)
        {
            isPlacingMarker = true;
            awaitingClick = true;
            isRemovingMarker = false;
            OverlayCanvas.Cursor = Cursors.Cross;
        }
        private void ToolBox_RemoveMarkerModeDeactivated(object sender, EventArgs e)
        {
            isPlacingMarker = false;
            isRemovingMarker = true;
            OverlayCanvas.Cursor = Cursors.Arrow;
        }
        public void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isPlacingMarker && awaitingClick)
            {
                
                
                
                Point pos = e.GetPosition(OverlayCanvas);
                Marker marker = new Marker()
                {
                    X = pos.X,
                    Y = pos.Y,
                    
                };

                var markerRepresenter = new MarkerControl();
                Canvas.SetLeft(markerRepresenter, pos.X);
                Canvas.SetTop(markerRepresenter, pos.Y);
                OverlayCanvas.Children.Add(markerRepresenter);
                // Set the popup's position and show it
              MarkerAdded?.Invoke(this, new MarkerEventArgs(pos));
                
               

            }
            else if (isRemovingMarker)
            {
                var marker = Markers.FirstOrDefault(m => m.X == e.GetPosition(mapImage).X && m.Y == e.GetPosition(mapImage).Y);
                if (marker != null)
                {
                    Markers.Remove(marker);
                }
            }
        }
        public void OpenMarkerPopup(object sender,MarkerEventArgs e)
        {
           if (isPlacingMarker)
            {
                OverlayCanvas.Cursor = Cursors.Arrow;
                MarkerPopupControl markerPopupControl = new MarkerPopupControl(e.Point);
                { markerPopupControl.ResidentListData = UnassignedResidents; }

                        

                isPlacingMarker = false;
                Canvas.SetLeft(markerPopupControl, 100);
                Canvas.SetTop(markerPopupControl, 100);
                OverlayCanvas.Children.Add(markerPopupControl);
                
                markerPopupControl.Visibility = Visibility.Visible;
                markerPopupControl.CloseRequested += CloseChildItem;
                awaitingClick = false;
            }
        }
        public BitmapImage ConvertByteArrayToBitmapImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0) return null;

            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageBytes))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
        public void DrawMarker()
        {
            foreach (var plot in  Markers)
            {
                MarkerControl drawMarker = new();
                Canvas.SetLeft(drawMarker, plot.X);
                Canvas.SetTop(drawMarker, plot.Y);
                OverlayCanvas.Children.Add(drawMarker); drawMarker.Visibility = Visibility.Visible;
            }
        }
        public void CloseChildItem(object sender, EventArgs e)
        {
            Console.WriteLine("Test");
            if (OverlayCanvas.Children.Contains(sender as UIElement))
            {
                OverlayCanvas.Children.Remove(sender as UIElement);
            }

        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
        
    public class MarkerEventArgs : EventArgs
    {
        public Point Point { get; set; }
        public MarkerEventArgs(Point point)
        {
            this.Point = point;
        }
    }
}

