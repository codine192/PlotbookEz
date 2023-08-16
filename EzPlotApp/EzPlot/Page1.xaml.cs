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

namespace EzPlot
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private bool isPlacingMarker = false;
        
        public EzPlot.Models.Image homeImage { get; set; }
        public BitmapImage image { get; set; }
        public ObservableCollection<Marker> Markers { get; set; }
        public Marker CemeteryMarker { get; set; }
        
        public Page1()

        {

            InitializeComponent();
            DataContext = this;
            
           
            mapImage.Source = App.defaultImage;
            Marker marker = new()
            {
                
                X= 20,
                Y = 20,
                Label = "Cody",
                PlotID = 1,
                Type = "Grave"


            };
           
           
        }
        
       
        private void PlaceMarker_Click(object sender, RoutedEventArgs e)
        {
            isPlacingMarker = !isPlacingMarker;
            popupPanel.Visibility = isPlacingMarker ? Visibility.Visible : Visibility.Collapsed;
        }

        private void AddMarker_Click(object sender, RoutedEventArgs e)
        {
            // Add your logic to place a marker on the image
            // You can create a new marker element and add it to the image or a canvas
            // Example: Create an Ellipse and position it based on user click
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            isPlacingMarker = false;
            popupPanel.Visibility = Visibility.Collapsed;
        }
    }
}

