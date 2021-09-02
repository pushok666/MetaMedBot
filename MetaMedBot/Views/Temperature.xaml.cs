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
    /// Interaction logic for Temperature.xaml
    /// </summary>
    public partial class Temperature : UserControl
    {
        public int result = 0;
        public Temperature()
        {
            InitializeComponent();
            Random rand = new Random();
            result = rand.Next(35, 42);
            //App.DetailsDiagnostic.Temperature = result;

            resultLab.Content = result.ToString() + " C";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

            App.countUserC--;

            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Analysis Temp = new Analysis
            {
                Name = "Температура",
                Result = result,
                StartRange = 36,
                EndRange = 37
            };
            Temp.CheckRange();
            App.AnalysesList.Add(Temp);
            App.countUserC++;
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }
    }
}
