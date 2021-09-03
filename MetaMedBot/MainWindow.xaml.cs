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
using MetaMedBot.Views;
using MetaMedBot.ViewModelApplication;
using LiteDB;

namespace MetaMedBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<UserControl> userControls = new List<UserControl>();

        public static LiteDatabase db;

        public MainWindow()
        {
           
            //userControls.Add(new ImageResult());
            

            InitializeComponent();
            this.DataContext = new VMApplication();
            App.MContent = MainContent;
            //MainContent.Content = userControls[App.countUserC];



        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.countUserC--;

            MainContent.Content = userControls[App.countUserC];
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            userControls.Add(new Start_Page());
            userControls.Add(new IP());
            userControls.Add(new PP());
            userControls.Add(new Question());
            userControls.Add(new Question2());
            userControls.Add(new Question3());
            userControls.Add(new Question4());
            userControls.Add(new Question5());
            userControls.Add(new Question6());
            userControls.Add(new Question7());
            userControls.Add(new Question8());
            userControls.Add(new Question9());
            userControls.Add(new Question10());
            userControls.Add(new Question11());
            userControls.Add(new Question12());
            userControls.Add(new Question13());
            userControls.Add(new Question14());
            userControls.Add(new Question15());
            userControls.Add(new Question16());
            userControls.Add(new PollResult());
            userControls.Add(new Temperature());
            userControls.Add(new Pressure());
            userControls.Add(new Oxygen());
            userControls.Add(new Volume());
            userControls.Add(new Glucose());
            Start.IsEnabled = false;
            Start.Visibility = Visibility.Hidden;
            MainContent.Content = userControls[App.countUserC];
        }
    }
}
