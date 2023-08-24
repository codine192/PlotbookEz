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
using EzPlot.Models;

namespace EzPlot.Views
{
    /// <summary>
    /// Interaction logic for ViewPlotListPageView.xaml
    /// </summary>
    public partial class ViewPlotListPageView : Page
    {
        public List<Plot> plots = new List<Plot>();
        public ViewPlotListPageView()
        {
            InitializeComponent();
            using var context = new MYDBContext();
            plots = context.Plots.ToList();
            dataGridPlots.ItemsSource = plots;
            
        }
    }
}
