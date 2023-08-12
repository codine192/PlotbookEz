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

//namespace EzPlot
//{
//    internal class ViewerControls 
//    {
//        private Point lastMousePosition;

//        private void ImageScrollViewer_MouseMove(object sender, MouseEventArgs e)
//        {
//            if (e.LeftButton == MouseButtonState.Pressed)
//            {
//                Point newMousePosition = e.GetPosition(imageScrollViewer);
//                double deltaX = newMousePosition.X - lastMousePosition.X;
//                double deltaY = newMousePosition.Y - lastMousePosition.Y;

//                imageScrollViewer.ScrollToHorizontalOffset(imageScrollViewer.HorizontalOffset - deltaX);
//                imageScrollViewer.ScrollToVerticalOffset(imageScrollViewer.VerticalOffset - deltaY);

//                lastMousePosition = newMousePosition;
//            }
//            else
//            {
//                lastMousePosition = e.GetPosition(imageScrollViewer);
//            }
//        }


//    }
//}
