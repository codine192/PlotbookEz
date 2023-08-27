using EzPlot.Models;
using MvvmCross.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    public partial class MarkerPopupControl : UserControl, INotifyPropertyChanged
    {
        public EventHandler CloseRequested;
        public Point newPoint { get; set; }
        private Resident resident;
        public Resident Resident
        {
            get { return resident; }
            set
            {
                if (resident != value)
                {
                    resident = value;
                    OnPropertyChanged(nameof(Resident));
                }
            }
        }

        private double x;
        public double X
        {
            get { return x; }
            set
            {
                if (x  != value)
                {
                    x = value;
                    OnPropertyChanged(nameof(X));
                }
            }
        }
        private double y;
        public double Y
        {
            get { return y; }
            set
            {
                if (y != value)
                {
                    y = value;
                    OnPropertyChanged(nameof(Y));
                }
            }
        }
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

        public event PropertyChangedEventHandler? PropertyChanged;

        private static void OnPlotDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MarkerPopupControl;
            control.DataContext = e.NewValue as Plot;
        }

        private void OnCloseButtonClicked(object sender, RoutedEventArgs e)
        {
            CloseRequested?.Invoke(this, EventArgs.Empty);
        }
        private void OnSaveButtonClicked(object sender, RoutedEventArgs e)
        {
            Plot plot = new();
            plot.X = X;
            plot.Y = Y;
            plot.ResidentID = Resident.ID;
            

            
            using var context = new MYDBContext();
            var updateResident = context.Residents.FirstOrDefault(resident => resident.ID == Resident.ID);
            updateResident.AssignedToPlot = true;
            context.Plots.Add(plot);
            int isSaved = context.SaveChanges();
            if (isSaved > 0)
            {
                MessageBox.Show("Record successfully added!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                
            }
            else
            {
                MessageBox.Show("Failed to add record.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }






        }
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public MarkerPopupControl()
        {
            InitializeComponent();
            

        }
        public MarkerPopupControl( Point point)
        {
            X = point.X;
            Y = point.Y;
            InitializeComponent();
            
        }
    }
}
