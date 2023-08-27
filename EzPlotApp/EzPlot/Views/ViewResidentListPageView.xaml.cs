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
using EzPlot.Models;

namespace EzPlot.Views
{
    /// <summary>
    /// Interaction logic for ViewResidentListPageView.xaml
    /// </summary>
    public partial class ViewResidentListPageView : Page
    {
        public List<Resident> residents = new List<Resident>();
        public ViewResidentListPageView()
        {
            InitializeComponent();
            using var context = new MYDBContext();
            residents = context.Residents.ToList();
            dataGridResidents.ItemsSource = residents;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var grid = (DataGrid)sender;
            var selected = (Resident)grid.SelectedItem;
            if (selected != null)
            {
                // Navigate to new page
                 ViewResidentPageView newPage = new ViewResidentPageView(selected);
                NavigationService.Navigate(newPage);
            }
        }
    }
}
