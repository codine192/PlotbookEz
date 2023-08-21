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

namespace EzPlot.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private bool isPlacingMarker = false;
        private bool isRemovingMarker = false;
        private bool isAddingMarker = false;
        private bool awaitingClick = false;
        public event EventHandler LeftButton_Pressed;
        public ObservableCollection<Resident> UnassignedResidents { get; set; }
        public ObservableCollection<Resident> Residents { get; set; }
        public ObservableCollection<Cemetery> Cemetaries { get; set; } 
        
        public BitmapImage image { get; set; }
        public ObservableCollection<Marker> Markers { get; set; }
        public Marker CemeteryMarker { get; set; }
        public Plot Plot { get; set; }
        
        public PlotBook selectedPlotBook;
        public MainPage()

        {

            InitializeComponent();
            this.DataContext = this;

            if (selectedPlotBook == null) { mapImage.Source = App.defaultImage;}
            else { mapImage.Source = ConvertByteArrayToBitmapImage(selectedPlotBook.image); }
            markerToolBoxControl.PlaceMarkerModeActivated += ToolBox_PlacingMarkerModeActivated;
            markerToolBoxControl.RemoveMarkerModeActivated += ToolBox_RemoveMarkerModeDeactivated;
            using var db = new MYDBContext();
            UnassignedResidents = new ObservableCollection<Resident>(db.Residents.Where(r => r.PlotID == null));
            Cemetaries = new ObservableCollection<Cemetery>(db.Cemeteries);
            
            

            
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
                
                
                markerPopup.Visibility = Visibility.Visible;
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
                markerPopup.HorizontalOffset = pos.X;
                markerPopup.VerticalOffset = pos.Y;
                markerPopup.IsOpen = true;

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
    }
}

