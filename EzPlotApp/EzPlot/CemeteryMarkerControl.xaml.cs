using EzPlot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace EzPlot
{
    /// <summary>
    /// Interaction logic for CemeteryMarkerControl.xaml
    /// </summary>
    public partial class CemeteryMarkerControl : UserControl
    {
        public BitmapImage MarkerImage { get; set; }
        public CemeteryMarkerControl()
        {
            InitializeComponent();
            DataContext = new CemetaryMarker();
            
            
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            // Load the image from your app's directory
            BitmapImage markerImage = new BitmapImage(new Uri("marKker.png"));

            // Calculate the position where the image will be drawn
            double imageX = 212 - markerImage.Width / 2;
            double imageY = 53 - markerImage.Height / 2;

            // Draw the image on the canvas
            drawingContext.DrawImage(markerImage, new Rect(new Point(imageX, imageY), new Size(10,10)));
        }
    }
}
