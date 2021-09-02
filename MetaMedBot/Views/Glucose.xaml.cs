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

namespace MetaMedBot.Views
{
    /// <summary>
    /// Interaction logic for Glucose.xaml
    /// </summary>
    public partial class Glucose : UserControl
    {
        int result = 0;
        public Glucose()
        {
            InitializeComponent();
            Random rand = new Random();
            result = rand.Next(2, 7);
            resultLab.Content = result.ToString() + " ммоль/л";

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            App.AnalysesList2.Add(new ModelData.Analysis { Name = "Уровень глюкозы", StartRange = 3, EndRange = 6, Result =  result});
            App.countUserC++;
            MainWindow.userControls.Add(new ImageResult());
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var a = App.AnalysesList2.Last();
            App.AnalysesList2.Remove(a);
            App.countUserC--;
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }
    }
}
