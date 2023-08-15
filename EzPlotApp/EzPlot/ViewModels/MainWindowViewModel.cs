using EzPlot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace EzPlot.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindow MainWindowInstance { get; set; }
        private bool _isPlottingMode = true;

        public ICommand OpenPlotBookCommand { get; }
        public ICommand SavePlotBookCommand { get; }
        public ICommand OpenNewPlotBookCommand { get; private set; }
        public ICommand OpenAddNewResidentCommand { get; private set; }
        public ICommand OpenLoadPlotBookCommand { get; private set; }
        public ICommand SwitchToViewingModeCommand { get; private set; }
        public ICommand SwitchToPlottingModeCommand { get; private set; }
        public ICommand DisplaySelectedPlotBookImage { get; set; }
        private BitmapImage _displayedImage;
        public PlotBook SelectedPlotBook { get; set; }
        public BitmapImage DisplayedImage
        {
            get { return _displayedImage; }
            set
            {
                _displayedImage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DisplayedImage)));
            }
        }


        public MainWindowViewModel()
        {
            OpenNewPlotBookCommand = new RelayCommand(ExecuteOpenNewPlotBook, CanExecuteOpenNewPlotBook);
            OpenAddNewResidentCommand = new RelayCommand(ExecuteOpenAddNewResident, CanExecuteOpenAddNewResident);
            OpenLoadPlotBookCommand = new RelayCommand(ExecuteOpenLoadPlotBook, CanExecuteOpenLoadPlotBook);
            DisplaySelectedPlotBookImage = new RelayCommand(ExecuteDisplaySelectedPlotBookImage, CanExecuteDisplaySelectedPlotBookImage);
            SwitchToViewingModeCommand = new RelayCommand(SwitchToViewingMode);
            SwitchToPlottingModeCommand = new RelayCommand(SwitchToPlottingMode);
            
        }


        public void ExecuteOpenNewPlotBook(object obj)
        {
            // Navigate to Page1.xaml
            

            PlotBookDetailsWindow plotBookDetailsWindow = new();
            plotBookDetailsWindow.ShowDialog();
        }

        public bool CanExecuteOpenNewPlotBook(object obj)
        {
            return true;
        }
        public void ExecuteOpenAddNewResident(object obj)
        {
            AddResidentWindow addResidentWindow = new AddResidentWindow();
            addResidentWindow.ShowDialog();
        }
        public bool CanExecuteOpenAddNewResident(object obj)
        {
            return true;
        }
        public void ExecuteOpenLoadPlotBook(object obj)
        {
            App.Current.MainWindow.Hide();
            LoadPlotBookWindow loadPlotBookWindow = new LoadPlotBookWindow();
            loadPlotBookWindow.ShowDialog();


        }
        public bool CanExecuteOpenLoadPlotBook(object obj)
        {
            return true;
        }
        public void ExecuteDisplaySelectedPlotBookImage(object parameter)
        {
            using (var db = new MYDBContext())
            {

                
                byte[] imageData = db.PlotBooks
                    .Where(p => p.plotBookID == App.SelectedPlotBook.plotBookID)
                    .Select(p => p.image)
                    .FirstOrDefault();

                if (imageData != null)
                {
                    DisplayedImage = ConvertToBitmapImage(imageData);
                    OnPropertyChanged(nameof(DisplayedImage));
                    OnPropertyChanged(nameof(SelectedPlotBook));
                }
                SelectedPlotBook = App.SelectedPlotBook;
                OnPropertyChanged(nameof(SelectedPlotBook));
            }
        }
        private BitmapImage ConvertToBitmapImage(byte[] imageData)
        {
            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream memoryStream = new MemoryStream(imageData))
            {
                memoryStream.Position = 0;
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.EndInit();
            }
            return bitmapImage;
        }
        public bool CanExecuteDisplaySelectedPlotBookImage(object obj)
        {
            return true;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        public bool IsPlottingMode
        {
            get { return _isPlottingMode; }
            set
            {
                _isPlottingMode = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsPlottingMode)));
            }
        }
        private void SwitchToViewingMode(object obj)
        {
            IsPlottingMode = false;
        }

        private void SwitchToPlottingMode(object obj)
        {
            IsPlottingMode = true;
        }
        public class BooleanToVisibilityConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (value is bool boolValue)
                {
                    return boolValue ? Visibility.Visible : Visibility.Collapsed;
                }
                return Visibility.Collapsed;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }


    }

}

