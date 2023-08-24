using EzPlot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            int changeSaved = context.SaveChanges();

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }


    }
}


