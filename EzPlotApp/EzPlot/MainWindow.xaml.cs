using EzPlot.Models;
using EzPlot.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using System.Windows.Shapes;
using System.Windows.Ink;
using EzPlot.Views;
namespace EzPlot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public void OpenAddResident_ButtonClick(object sender, RoutedEventArgs e)

        {
           AddResidentPageView addResidentPageView = new AddResidentPageView();
            addResidentPageView.CloseRequested += CloseChildObject;
            MainFrame.Navigate(addResidentPageView);
        }
        public void OpenViewResidents_ButtonClick(object sender, RoutedEventArgs e)

        {
            ViewResidentListPageView viewResidentListPageView = new ViewResidentListPageView();
            MainFrame.Navigate(viewResidentListPageView);
        }
        public void OpenViewPlots_ButtonClick(Object sender, RoutedEventArgs e)
        {
            ViewPlotListPageView viewPlotListPageView = new ViewPlotListPageView();
            MainFrame.Navigate(viewPlotListPageView);
        }
        public void OpenAddPlotBook_ButtonClick(Object sender, RoutedEventArgs e)
        {
            AddPlotBookPageView addPlotBookPageView = new AddPlotBookPageView();
            MainFrame.Navigate(addPlotBookPageView);
        }
        public void OpenMap_ButtonClick(Object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new();
            MainFrame.Navigate(mainPage);
        }

        public void CloseChildObject(object sender, EventArgs e)
        {
            MainFrame.Content = new MainPage();
        }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            // Navigate to Page1.xaml
            MainFrame.Source=(new Uri("Views/MainPage.xaml", UriKind.Relative));

        }

        
        




    }

}

