using EzPlot.Models;
using EzPlot.ViewModels;
using Microsoft.Win32;
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
using System.Windows.Ink;
namespace EzPlot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Point _startPoint;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            // Navigate to Page1.xaml
            MainFrame.Source=(new Uri("Page1.xaml", UriKind.Relative));

        }

        
        //private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        //{
        //    // Set up the InkCanvas
        //    inkCanvas.DefaultDrawingAttributes = new DrawingAttributes
        //    {
        //        Color = Colors.Black,
        //        Height = 2,
        //        Width = 2

        //    };
        //    inkCanvas.EditingMode = InkCanvasEditingMode.Ink;

        //    // Subscribe to events to handle drawing

        //    inkCanvas.MouseDown += InkCanvas_MouseDown;
        //    inkCanvas.MouseMove += InkCanvas_MouseMove;
        //    inkCanvas.MouseUp += InkCanvas_MouseUp;
        //}

        //private void InkCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    inkCanvas.CaptureMouse();

        //    // Handle the start of drawing here
        //}

        //private void InkCanvas_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (inkCanvas.IsMouseCaptured)
        //    {
        //        // Handle ongoing drawing here
        //    }
        //}

        //private void InkCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    if (inkCanvas.IsMouseCaptured)
        //    {
        //        inkCanvas.ReleaseMouseCapture();
        //        // Handle the end of drawing here
        //    }
        //}




    }

}

