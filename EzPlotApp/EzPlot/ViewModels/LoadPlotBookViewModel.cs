using EzPlot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using System.Windows;

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
                // Save the selected plot book for later use
                App.SelectedPlotBook = SelectedPlotBook;

                // Close the window (if applicable)
                if (parameter is Window window)
                {
                    window.Close();
                }
                App.Current.MainWindow.Show();
                // Call a method in your main application to display the image
                // You can replace "YourMainWindow" with the actual class name of your main window

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
