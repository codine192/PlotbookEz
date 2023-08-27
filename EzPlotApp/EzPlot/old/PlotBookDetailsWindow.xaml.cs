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
using System.Windows.Shapes;
using EzPlot.ViewModels;
namespace EzPlot.Views
{
    /// <summary>
    /// Interaction logic for PlotBookDetailsWindow.xaml
    /// </summary>
    public partial class PlotBookDetailsWindow : Window
    {
        public PlotBookDetailsWindow()
        {
            InitializeComponent();
            DataContext = new PlotBookViewModel();
        }
        

    }
}
