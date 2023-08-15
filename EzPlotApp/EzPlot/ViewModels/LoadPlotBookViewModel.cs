using EzPlot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;

namespace EzPlot.ViewModels
{
    public class LoadPlotBookViewModel : INotifyPropertyChanged
    {
        public List<PlotBook> PlotBooksList { get; set; }
        private PlotBook _selectedPlotBook;
        public MainWindowViewModel mainWindowViewModel{ get; set; }

        public ICommand LoadPlotBookCommand { get; set; }

        public LoadPlotBookViewModel()
        {
            using var db = new MYDBContext();
            PlotBooksList = db.PlotBooks.ToList();

            LoadPlotBookCommand = new RelayCommand(ExecuteLoadPlotBookCommand,CanExecuteLoadPlotBookCommand);
           

        }
        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        public void ExecuteLoadPlotBookCommand(object parameter)
        {
            if (SelectedPlotBook != null)
            {
                using MemoryStream memoryStream = new MemoryStream(SelectedPlotBook.image);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = memoryStream;
                image.EndInit();
                App.defaultImage = image;
            }

        }
        public bool CanExecuteLoadPlotBookCommand(object parameter)
        {
            return true;
        }
        public PlotBook SelectedPlotBook
        {
            get
            {
                return _selectedPlotBook;
            }
            set
            {
                _selectedPlotBook = value;
                OnPropertyChanged("SelectedPlotBook");
            }
        }   
       



        public event PropertyChangedEventHandler PropertyChanged;
    }
}
