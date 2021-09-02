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
using MetaMedBot.ResultViews;
using MetaMedBot.ViewModelApplication;

namespace MetaMedBot.Views
{
    /// <summary>
    /// Interaction logic for ImageResult.xaml
    /// </summary>
    public partial class ImageResult : UserControl
    {
        public ImageResult()
        {
            Start_Page.timer.Stop();
            Start_Page.timer.Interval = TimeSpan.FromSeconds(300);
            InitializeComponent();
            this.DataContext = new VMResult();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Email_Click(object sender, RoutedEventArgs e)
        {
            Start_Page.timer.Stop();
            App.MContent.Content = new SendEmail();
        }
    }
}
