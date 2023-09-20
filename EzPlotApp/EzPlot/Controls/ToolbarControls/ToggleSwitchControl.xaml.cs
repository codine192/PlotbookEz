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
using System.Windows.Threading;

namespace EzPlot.Controls.ToolbarControls
{
    /// <summary>
    /// Interaction logic for ToggleSwitchControl.xaml
    /// </summary>
    public partial class ToggleSwitchControl : UserControl

    {
        public EventHandler SwitchToggled;
        

        public ToggleSwitchControl()
        {
            InitializeComponent();
        }

        public void ToggleSwitch_Checked(object sender, RoutedEventArgs e)

        {
            //Enable MessageBox
            
            
            EnablePopup.IsOpen = true;
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (sender, e) =>
            {
                // Hide the control
                EnablePopup.IsOpen = false;

                // Stop the timer
                timer.Stop();
            };

            // Start the timer
            timer.Start();
            SwitchToggled.Invoke(this, EventArgs.Empty);
        }
        public void ToggleSwitch_Uncheck(object sender, RoutedEventArgs e)
        {
            DisablePopup.IsOpen = true;
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (sender, e) =>
            {
                // Hide the control
                DisablePopup.IsOpen = false;

                // Stop the timer
                timer.Stop();
            };

            // Start the timer
            timer.Start();
            SwitchToggled.Invoke(this, EventArgs.Empty);
        }

        private void EnabledMessageBox_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
