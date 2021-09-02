using MetaMedBot.ModelData;
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
    /// Interaction logic for Question13.xaml
    /// </summary>
    public partial class Question13 : UserControl
    {
        public Question13()
        {
            InitializeComponent();
        }

        private void Back1_Click(object sender, RoutedEventArgs e)
        {
            var last = App.SmokerList.Last();
            App.SmokerList.Remove(last);
            App.countUserC--;
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }

        private void ListQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListQuestions.SelectedItems.Count != 0)
            {
                Answer answer = (Answer)ListQuestions.SelectedItems[0];
                string strAnswer = answer.Id.ToString() + "#" + answer.Aanswer + "#" + answer.Score;
                App.SmokerList.Add(strAnswer);
                App.countUserC++;
                ListQuestions.SelectedItem = null;
                App.MContent.Content = MainWindow.userControls[App.countUserC];
            }
        }
    }
}
