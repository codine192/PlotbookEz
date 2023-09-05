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
        public GridMakerPopupControl PopupControl { get; set; }
        public GridMakerButtonControl()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PopupControl = new GridMakerPopupControl();
            PopupControl.GridMakerPopup.PlacementTarget = this;
            PopupControl.GridMakerPopup.IsOpen = true;
            
        }
    }
}



   
