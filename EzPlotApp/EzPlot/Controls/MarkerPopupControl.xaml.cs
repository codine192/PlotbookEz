using EzPlot.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace EzPlot.Controls
{
    /// <summary>
    /// Interaction logic for MarkerPopupControl.xaml
    /// </summary>
    public partial class MarkerPopupControl : UserControl
    {
        public Plot PlotData
        {
            get { return (Plot)GetValue(PlotDataProperty); }
            set { SetValue(PlotDataProperty, value); }
        }

        public ObservableCollection<Plot> PlotListData
        {
            get { return (ObservableCollection<Plot>)GetValue(PlotListProperty); }
            set { SetValue(PlotListProperty, value); }
        }

        public ObservableCollection<Resident> ResidentListData
        {
            get { return(ObservableCollection<Resident>)GetValue(ResidentListProperty); }
            set { SetValue(ResidentListProperty, value); }
        }

        public static readonly DependencyProperty PlotDataProperty =
            DependencyProperty.Register("PlotData", typeof(Plot), typeof(MarkerPopupControl), new PropertyMetadata(new Plot()));

        public static readonly DependencyProperty PlotListProperty =
                       DependencyProperty.Register("PlotList", typeof(ObservableCollection<Plot>), typeof(MarkerPopupControl), new PropertyMetadata(new ObservableCollection<Plot>() ));

        public static readonly DependencyProperty ResidentListProperty=
                       DependencyProperty.Register("ResidentList", typeof(ObservableCollection<Resident>), typeof(MarkerPopupControl), new PropertyMetadata(new ObservableCollection<Resident>() ));

        private static void OnPlotDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MarkerPopupControl;
            control.DataContext = e.NewValue as Plot;
        }

        private void OnCloseButtonClicked(object sender, RoutedEventArgs e)
        {
            
        }
        private void OnSaveButtonClicked(object sender, RoutedEventArgs e)
        {
            
        }
        public MarkerPopupControl()
        {
            InitializeComponent();
        }
    }
}
