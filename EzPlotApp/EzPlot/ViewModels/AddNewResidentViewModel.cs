using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EzPlot.Models;

namespace EzPlot.ViewModels
{
    public class AddNewResidentViewModel : INotifyPropertyChanged
    {
        public List<Plot> availablePlots { get; set; }
        public ICommand SaveNewResidentCommand { get; private set; }
        public ICommand CloseSaveResidentConfirmationWindow { get; private set; }   
        
        
        public event PropertyChangedEventHandler? PropertyChanged;

        public AddNewResidentViewModel()
        {
            SaveNewResidentCommand = new RelayCommand(ExecuteSaveNewResident, CanExecuteSaveNewResident);
            CloseSaveResidentConfirmationWindow = new RelayCommand(ExecuteCloseSaveResidentConfirmationWindow, CanExecuteCloseSaveResidentConfirmationWindow);
            availablePlots = new List<Plot>();
            using (var db = new MYDBContext())
            {
                availablePlots = db.Plots.ToList();
            }
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
        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        public void ExecuteSaveNewResident(object obj)
        {
            using var db = new MYDBContext();
            Resident newResident = new Resident();
            newResident.FirstName = FirstName;
            newResident.LastName = LastName;
            newResident.BirthDate = BirthDate;
            newResident.DeathDate = DeathDate;
            newResident.DateAdded = DateTime.Now;
            
            db.Residents.Add(newResident);
            int savedChanged = db.SaveChanges();
            if (savedChanged > 0)
            {
                IsSaved = true;
            }
            else
            {
                Console.WriteLine("Resident not saved");
            }
            
            

        }
        public bool CanExecuteSaveNewResident(object obj)
        {
            return true;
        }
        public void ExecuteCloseSaveResidentConfirmationWindow(object obj)
        {
            IsSaved = false;
        }
        public bool CanExecuteCloseSaveResidentConfirmationWindow(object obj)
        {
            return true;
        }
        private string _firstname;
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                OnPropertyChanged("FirstName");
                OnPropertyChanged("FullName");
            }
        }
        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                OnPropertyChanged  ("LastName");
                OnPropertyChanged("FullName");
            }
        }
        private string _fullName;
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = $"{_firstname} {_lastname}";
                OnPropertyChanged("FullName");
            }
        }
        private DateTime _birthdate;
        public DateTime BirthDate
        {
            get
            {
                return _birthdate;
            }
            set
            {
                _birthdate = value;
                OnPropertyChanged("BirthDate");
            }
        }
        private DateTime _deathdate;
        public DateTime DeathDate
        {
            get
            {
                return _deathdate;
            }
            set
            {
                _deathdate = value;
                OnPropertyChanged("DeathDate");
            }
        }
        private DateTime _dateadded;
        public DateTime DateAdded
        {
            get
            {
                return _dateadded;
            }
            set
            {
                _dateadded = value;
                OnPropertyChanged("DateAdded");
            }
        }
        private int _plotid;
        public int PlotID
        {
            get
            {
                return _plotid;
            }
            set
            {
                _plotid = value;

            }
        }

    }

    
        
    
}
