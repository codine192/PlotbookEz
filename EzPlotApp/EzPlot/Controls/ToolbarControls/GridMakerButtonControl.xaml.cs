using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace EzPlot.Controls.ToolbarControls
{
    /// <summary>
    /// Interaction logic for GridMakerButtonControl.xaml
    /// </summary>
    public partial class GridMakerButtonControl : UserControl 
    {
        public GridMakerControl GridMaker { get; set; }
        public GridMakerPopupControl Popup { get; set; }
      
        public GridMakerButtonControl()
        {
            InitializeComponent();
         Popup = new GridMakerPopupControl();
            Popup.GridMakerPopup.IsOpen = false;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
           if (Popup.GridMakerPopup.IsOpen == false)
            {
                Popup.GridMakerPopup.PlacementTarget = this;
                Popup.GridMakerPopup.IsOpen = true;
            }
            else
            {
                Popup.GridMakerPopup.IsOpen = false;
            }
        }
    }
}



   
