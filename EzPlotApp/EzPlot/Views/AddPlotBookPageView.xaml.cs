using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using Microsoft.Win32;
using EzPlot.Models;
using System.Collections.ObjectModel;

namespace EzPlot.Views
{
    /// <summary>
    /// Interaction logic for AddPlotBookPageView.xaml
    /// </summary>
    /// 

    
    public partial class AddPlotBookPageView : Page, INotifyPropertyChanged


    {
        
        public Cemetery cemetery { get; set; }
        public List<Cemetery> Cemeteries { get; set; }
        private int selectedID;
        private BitmapImage uploadedImage;
        public BitmapImage UploadedImage
        {
            get { return uploadedImage; }
            set
            {
                if (uploadedImage != value)
                {
                    uploadedImage = value;
                    OnPropertyChanged(nameof(UploadedImage));
                }
            }
        }
        public int SelectedID
        {
            get { return selectedID; }
            set
            {
                if (selectedID != value)
                {
                    selectedID = value;
                    OnPropertyChanged(nameof(SelectedID));
                }
            }


        }
        private string name;
        public string NameOfCem
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(NameOfCem));
                }
            }
        }

        private byte[] imageData;
        public byte[] Image
        {
            get { return imageData; }
            set
            {
                if (imageData != value)
                {
                    imageData = value;
                    OnPropertyChanged(nameof(Image));
                }

            }
        }

        public string AerialImagePath { get; private set; }

        public AddPlotBookPageView()
        {
            

            using var context = new MYDBContext();
            Cemeteries = context.Cemeteries.ToList();
            InitializeComponent();
            


        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void OnUploadImage_ButtonClick(object sender, RoutedEventArgs e)
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
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                    fs.Close();
                }
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.StreamSource = memoryStream;
                    image.EndInit();
                    UploadedImage = image;
                   
                }
            }
        }
        public void OnSavePlotBook_ButtonClick(object sender, RoutedEventArgs e)
        {
            PlotBook Plotbook = new PlotBook();
            Plotbook.name = Name;
            Plotbook.image = Image;
            Plotbook.CemeteryID = SelectedID;
            using var context = new MYDBContext();
            context.PlotBooks.Add(Plotbook);
            int isSaved = context.SaveChanges();
            if (isSaved > 0)
            {
                App.SelectedPlotBook = Plotbook;
                MessageBox.Show("Record successfully added!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new Uri("Views/MainPage.xaml", UriKind.Relative));
                
            }
            else
            {
                MessageBox.Show("Failed to add record.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                NavigationService.Navigate(new Uri("Views/MainPage.xaml", UriKind.Relative));
            }

        }
    }
}
