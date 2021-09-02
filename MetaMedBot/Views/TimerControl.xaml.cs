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

namespace MetaMedBot.Views
{
    /// <summary>
    /// Interaction logic for TimerControl.xaml
    /// </summary>
    public partial class TimerControl : UserControl
    {
        static DispatcherTimer tm = new DispatcherTimer();
        public TimerControl()
        {
            InitializeComponent();
            tm.Interval = TimeSpan.FromSeconds(10);
            tm.Tick += Tm_Tick;
            tm.Start();
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            Start_Page.timer.Stop();
            tm.Stop();
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Yeas_Click(object sender, RoutedEventArgs e)
        {
            tm.Stop();
            App.MContent.Content = MainWindow.userControls[App.countUserC];
            Start_Page.timer.Start();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            tm.Stop();
            Start_Page.timer.Stop();
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
