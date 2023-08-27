using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using EzPlot.ViewModels;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EzPlot.Views
{
    /// <summary>
    /// Interaction logic for AddResidentWindow.xaml
    /// </summary>
    public partial class AddResidentWindow : Window
    {
        
        public AddResidentWindow()
        {
            InitializeComponent();
            DataContext = new AddNewResidentViewModel();
        }
    }
}
