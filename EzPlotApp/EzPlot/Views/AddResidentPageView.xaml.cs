using EzPlot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
    /// Interaction logic for AddResidentPageView.xaml
    /// </summary>
    public partial class AddResidentPageView : Page, INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private DateTime dob;
        private DateTime dod;
        private DateTime dateAdded;
        private BitmapImage headstone;
        private string headstoneimagepath;
        private byte[] imageData;
        public EventHandler CloseRequested;
        public Resident Resident { get; set; }
        public DateTime CurrentDay { get; set; }

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
        public String FirstName
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
        public String LastName
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
        //Expander Content//
        //Contact Info
        private string _contactFirstName;
        private string _contactLastName;
        private string _contactEmail;
        private string _contactPhone;
        private string _contactAddress;
        private string _contactCity;
        private string _contactState;
        private string _contactZip;

        public string ContactFirstName
        {
            get { return _contactFirstName; }
            set
            {
                if (_contactFirstName != value)
                {
                    _contactFirstName = value;
                    OnPropertyChanged(nameof(ContactFirstName));
                }
            }
        }
        public string ContactLastName
        {
            get { return _contactLastName; }
            set
            {
                if (_contactLastName != value)
                {
                    _contactLastName = value;
                    OnPropertyChanged(nameof(ContactLastName));
                }
            }
        }
        public string ContactEmail
        {
            get { return _contactEmail; }
            set
            {
                if (_contactEmail != value)
                {
                    _contactEmail = value;
                    OnPropertyChanged(nameof(ContactEmail));
                }
            }
        }
        public string ContactPhone
        {
            get { return _contactPhone; }
            set
            {
                if (_contactPhone != value)
                {
                    _contactPhone = value;
                    OnPropertyChanged(nameof(ContactPhone));
                }
            }
        }
        public string ContactAddress
        {
            get { return _contactAddress; }
            set
            {
                if (_contactAddress != value)
                {
                    _contactAddress = value;
                    OnPropertyChanged(nameof(ContactAddress));
                }
            }
        }
        public string ContactCity
        {
            get { return _contactCity; }
            set
            {
                if (_contactCity != value)
                {
                    _contactCity = value;
                    OnPropertyChanged(nameof(ContactCity));
                }
            }
        }
        public string ContactState
        {
            get { return _contactState; }
            set
            {
                if (_contactState != value)
                {
                    _contactState = value;
                    OnPropertyChanged(nameof(ContactState));
                }
            }
        }
        public string ContactZip
        {
            get { return _contactZip; }
            set
            {
                if (_contactZip != value)
                {
                    _contactZip = value;
                    OnPropertyChanged(nameof(ContactZip));
                }
            }
        }


      
        public AddResidentPageView()
        {
            CurrentDay = DateTime.Now;
            InitializeComponent();
            Resident = new Resident();

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnSave_ButtonClick(object sender, RoutedEventArgs e)
        {
            using var context = new MYDBContext();
            Resident.FirstName = FirstName;
            Resident.LastName = LastName;
            Resident.DeathDate = DOD;
            Resident.BirthDate = DOB;
            Resident.DateAdded = DateTime.Now;
            context.Residents.Add(Resident);
            int isSaved = context.SaveChanges();
            if (isSaved > 0)
            {
                MessageBox.Show("Record successfully added!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new Uri("Views/MainPage.xaml", UriKind.RelativeOrAbsolute));
            }
            else
            {
                MessageBox.Show("Failed to add record.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        public BitmapImage HeadStone
        {
            get { return headstone; }
            set
            {
                if (headstone != value)
                {
                    headstone = value; OnPropertyChanged(nameof(HeadStone));
                }
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }

        public void OnUploadImage_ButtonClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() == true)
            {
                headstoneimagepath = openFileDialog.FileName;
                OnPropertyChanged(nameof(headstoneimagepath));

                // Read the image file into a byte array
                using (FileStream fs = new FileStream(headstoneimagepath, FileMode.Open, FileAccess.Read))
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
            if (headstone != null)
            {
                headStoneContainer.Visibility = Visibility.Visible;
                uploadButton.Visibility = Visibility.Hidden;
            }
        }
        private void OnCloseButtonClicked(object sender, RoutedEventArgs e)
        {
            CloseRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}


