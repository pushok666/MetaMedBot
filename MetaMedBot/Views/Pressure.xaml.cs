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
using MetaMedBot.ModelData;

namespace MetaMedBot.Views
{
    /// <summary>
    /// Interaction logic for Pressure.xaml
    /// </summary>
    public partial class Pressure : UserControl
    {
        int result = 0;
        public Pressure()
        {
            InitializeComponent();
            Random rand = new Random();
            result = rand.Next(101, 135);
            resultLab.Content = result.ToString() + " мм. рт. ст.";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var a = App.AnalysesList.Last();
            App.AnalysesList.Remove(a);
            App.countUserC--;
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Analysis Pressure = new Analysis
            {
                Name = "Артериальное давление",
                StartRange = 100,
                EndRange = 140,
                Result = result
            };
            //Pressure.CheckRange();
            App.AnalysesList.Add(Pressure);
            
            App.countUserC++;
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }
    }
}
