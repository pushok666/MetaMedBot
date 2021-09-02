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
using LiteDB;

namespace MetaMedBot.Views
{
    /// <summary>
    /// Interaction logic for Start_Page.xaml
    /// </summary>
    public partial class Start_Page : UserControl
    {
        public static DispatcherTimer timer = new DispatcherTimer();
        public Start_Page()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(15);
            timer.Tick += Timer_Tick;
            
            Application.Current.MainWindow.KeyUp += MainWindow_KeyUp;
            Application.Current.MainWindow.TouchDown += MainWindow_TouchDown;
            Application.Current.MainWindow.MouseDown += MainWindow_MouseDown;
            Application.Current.MainWindow.MouseMove += MainWindow_MouseMove;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void MainWindow_TouchDown(object sender, TouchEventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            App.MContent.Content = new TimerControl();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            App.countUserC++;
            App.MContent.Content =MainWindow.userControls[App.countUserC];
            MainWindow.db = new LiteDatabase(@"D:\работа\MetaMedBot\MetaMedBot\dbBoozer");
        }
    }
}
