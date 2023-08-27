using EzPlot.Models;
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

namespace EzPlot.Views
{
    /// <summary>
    /// Interaction logic for ViewResidentPageView.xaml
    /// </summary>
    public partial class ViewResidentPageView : Page,INotifyPropertyChanged
    {
        
        public ViewResidentPageView(Resident resident) 
        {
            InitializeComponent();

            this.DataContext = this;
            FirstName = resident.FirstName;
            LastName = resident.LastName;
            DOB = resident.BirthDate;
            DOD = resident.DeathDate;
            DateAdded = resident.DateAdded;
            if (resident.HeadStoneImageData != null) { headStone=Resident.HeadStoneImage;headStoneContainer.Visibility = Visibility.Visible; }
            else
            {
                headStoneContainer.Visibility = Visibility.Hidden;
                uploadButton.Visibility = Visibility.Visible;
            }


        }

        private string firstName;
        private string lastName;
        private DateTime dob;
        private DateTime dod;
        private DateTime dateAdded;
        private BitmapImage headStone;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Resident Resident { get; set; }
        public DateTime CurrentDay { get; set; }

        public BitmapImage HeadStone
        {
            get { return headStone; }
            set
            {
                if (headStone != value)
                {
                    headStone = value; OnPropertyChanged(nameof(HeadStone));
                }
            }
        }
        public DateTime DOB
        {
            get { return dob; }
            set
            {
                if (dob != value)
                {
                    dob = value;
                    OnPropertyChanged(nameof(DOB));
                }
            }
        }
        public DateTime DOD
        {
            get { return dod; }
            set
            {
                if (dod != value)
                {
                    dod = value;
                    OnPropertyChanged(nameof(DOD));
                }
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }
        public DateTime DateAdded
        {
            get { return dateAdded; }
            set
            {
                if (dateAdded != value)
                {
                    dateAdded = value;
                    OnPropertyChanged(nameof(DateAdded));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }

        private string HeadstoneImagePath { get; set; }
        private byte[] imageData;
        public void OnUploadImage_ButtonClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() == true)
            {
                HeadstoneImagePath = openFileDialog.FileName;
                OnPropertyChanged(nameof(HeadstoneImagePath));

                // Read the image file into a byte array
                using (FileStream fs = new FileStream(HeadstoneImagePath, FileMode.Open, FileAccess.Read))
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
                    HeadStone = image;

                }
                
            }
            if (headStone != null)
            {
                headStoneContainer.Visibility = Visibility.Visible;
                uploadButton.Visibility = Visibility.Hidden;
            }
        }

    }
}
