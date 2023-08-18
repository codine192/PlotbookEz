using MvvmCross.Base;
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

namespace EzPlot.Controls
{
    public partial class MarkerToolBoxControl : UserControl
    {
        public bool IsPlaceMarkerMode { get; private set; } = false;
        public bool IsRemoveMarkerMode { get; private set; } = false;

        public event EventHandler PlaceMarkerModeActivated;
        public event EventHandler RemoveMarkerModeActivated;

        public MarkerToolBoxControl()
        {
            InitializeComponent();
        }

        public void PlaceMarker_Click(object sender, RoutedEventArgs e)
        {
            IsPlaceMarkerMode = !IsPlaceMarkerMode;
            IsRemoveMarkerMode = false;  // Turn off Remove mode if Place mode is activated
            if (IsPlaceMarkerMode)
            {
                PlaceMarkerModeActivated?.Invoke(this, EventArgs.Empty);
            }
        }

        public void RemoveMarker_Click(object sender, RoutedEventArgs e)
        {
            IsRemoveMarkerMode = !IsRemoveMarkerMode;
            IsPlaceMarkerMode = false;  // Turn off Place mode if Remove mode is activated
            if (IsRemoveMarkerMode)
            {
                RemoveMarkerModeActivated?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

