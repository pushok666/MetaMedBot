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
    /// Interaction logic for Oxygen.xaml
    /// </summary>
    public partial class Oxygen : UserControl
    {
        int pyls = 0;
        int oxyge = 0;
        public Oxygen()
        {
            InitializeComponent();
            Random rand = new Random();
            pyls = rand.Next(80, 100);
            oxyge = rand.Next(60, 80);
            resultLab.Content = oxyge.ToString() + "%";
            resultPyls.Content = pyls.ToString() + "уд/сек";
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
            App.AnalysesList.Add(new ModelData.Analysis { Name = "Пульс", EndRange = 80, StartRange = 60, Result = pyls });
            App.AnalysesList2.Add(new ModelData.Analysis { Name = "Концентрация кислорода в крови", StartRange = 95, EndRange = 99, Result = oxyge });
            App.countUserC++;
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }
    }
}
