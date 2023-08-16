using EzPlot.Models;
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

namespace EzPlot
{
    public partial class MarkerControl : UserControl
    {
        public Marker MarkerData
        {
            get { return (Marker)GetValue(MarkerDataProperty); }
            set { SetValue(MarkerDataProperty, value); }
        }

        public ImageSource MarkerImage
        {
            get { return (ImageSource)GetValue(MarkerDataProperty); }
            set { SetValue(MarkerDataProperty, value); }
        }





        // Using a DependencyProperty as the backing store for MarkerData.
        // This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MarkerDataProperty =
            DependencyProperty.Register("MarkerData", typeof(Marker), typeof(MarkerControl), new PropertyMetadata(null, OnMarkerDataChanged));

        // Using a DependencyProperty as the backing store for MarkerImage.
        public static readonly DependencyProperty MarkerImageProperty =
            DependencyProperty.Register("MarkerImage", typeof(ImageSource), typeof(MarkerControl), new PropertyMetadata(new BitmapImage(new Uri("pack://application:/marker.png"))));
        private static void OnMarkerDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MarkerControl;
            control.DataContext = e.NewValue as Marker;
        }

        public MarkerControl()
        {
            InitializeComponent();
        }
    }
}
