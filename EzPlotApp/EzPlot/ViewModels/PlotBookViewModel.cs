using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EzPlot.Models;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace EzPlot.ViewModels
{
    public class PlotBookViewModel : INotifyPropertyChanged
    {

        private PlotBook _plotBook;
        private byte[] _imageData;

        public string AerialImagePath { get; set; }
        public ICommand FindAerialCommand { get; private set; }
        public ICommand SavePlotBookCommand { get; private set; }
        public ICommand CloseSavePlotBookConfirmWindowCommand { get; private set; }
        public PlotBookViewModel(PlotBook plotBook)
        {
            _plotBook = plotBook;
        }


        public string Name
        {
            get { return _plotBook.name; }
            set
            {
                if (_plotBook.name != value)
                {
                    _plotBook.name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public int CemeteryID
        {
            get { return _plotBook.CemeteryID; }
            set
            {
                if (_plotBook.CemeteryID != value)
                {
                    _plotBook.CemeteryID = value;
                    OnPropertyChanged(nameof(CemeteryID));
                }
            }
        }

        public List<Plot> Plots
        {
            get { return (List<Plot>)_plotBook.Plots; }
            set
            {
                if (_plotBook.Plots != value)
                {
                    _plotBook.Plots = value;
                    OnPropertyChanged(nameof(Plots));
                }
            }
        }

        public PlotBookViewModel()
        {
            FindAerialCommand = new RelayCommand(ExecuteFindAerialFile, CanExecuteFindAerialFile);
            SavePlotBookCommand = new RelayCommand(ExecuteSavePlotBook, CanExecuteSavePlotBook);
            
            _plotBook = new PlotBook();
        }
        private bool _issaved;
        public bool IsSaved
        {
            get
            {
                return _issaved;
            }
            set
            {
                _issaved = value;
                OnPropertyChanged("IsSaved");
            }
        }
        public void ExecuteSavePlotBook(object obj)
        {
            using (var db = new MYDBContext())
            {
                  
                
                
                // Save plot book to PlotBooks table
                _plotBook.image = _imageData;
                db.PlotBooks.Add(_plotBook);
                int savedChanged = db.SaveChanges();
                if (savedChanged > 0)
                {
                    IsSaved = true;

                }
            }
        }
        public bool CanExecuteSavePlotBook(object obj)
        {
            bool check;
            // Here, check if the aerial image path is valid.
            return true;// If it is, return true.
            // Otherwise, return false.
            // ...
        }
        public void ExecuteFindAerialFile(object obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() == true)
            {
                AerialImagePath = openFileDialog.FileName;
                OnPropertyChanged(nameof(AerialImagePath));

                // Read the image file into a byte array
                using (FileStream fs = new FileStream(AerialImagePath, FileMode.Open, FileAccess.Read))
                {
                    _imageData = new byte[fs.Length];
                    fs.Read(_imageData, 0, (int)fs.Length);
                    fs.Close();
                }
            }
        }
        public bool CanExecuteFindAerialFile(object obj)
        {

            bool check;
            // Here, check if the aerial image path is valid.
            return true;// If it is, return true.
            // Otherwise, return false.
            // ...
        }
        public void ExecuteCloseSavePlotBookConfirmWindow(object obj)
        {
            
        }
        public bool CanExecuteCloseSavePlotBookConfirmWindow(object obj)
        {
            return true;
        }
       

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
