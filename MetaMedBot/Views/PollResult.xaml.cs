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
    /// Interaction logic for PollResult.xaml
    /// </summary>
    public partial class PollResult : UserControl
    {
        public PollResult()
        {
            InitializeComponent();
        }

        private void ShowResult_Click(object sender, RoutedEventArgs e)
        {
            SendEmailButton.Visibility = Visibility.Visible;
            int alcoholResult = 0;
            foreach (var item in App.AnswerList) // calculate alcohol addiction
            {
                string[] answerArr = item.Split('#');
                string val = answerArr[2];
                alcoholResult += Convert.ToInt32(val);
            }

            if (alcoholResult >= 0 && alcoholResult <= 7)
            {
                AlcoholResult.Text = "У Вас пониженный риск возникновения проблем," +
                    "обусловленных употреблением алкоголя.";
            }
            if (alcoholResult >= 8 && alcoholResult <= 15)
            {
                AlcoholResult.Text = "у Вас есть вероятность " +
                    "злоупотребление алкоголя";
            }
            if (alcoholResult >= 16)
            {
                AlcoholResult.Text = "Вам требуется диагностическое уточнение " +
                    "из-за наличия возможной алкогольной зависимости";
            }
            int smokeResult = 0;
            foreach (var item in App.SmokerList)
            {
                if (item == "Некурящий")
                {
                    SmokeResult.Visibility = Visibility.Hidden;
                    break;
                }
                string[] answerArr = item.Split('#');
                string val = answerArr[2];
                smokeResult += Convert.ToInt32(val);
            }

            if (smokeResult >= 0 && smokeResult <= 2)
            {
                SmokeResult.Text = "Вам пока что не требуется медицинская помощь, но пока не поздно надо взять волю в кулак и бросить курить";
            }
            if (smokeResult == 3 || smokeResult == 4)
            {
                SmokeResult.Text = "У Вас легкая зависимость. Вы можете получить медицинскую помощь у любого врача. Или позвонить на горячую линию -8-800-200-0-200";
            }
            if (smokeResult>=5)
            {
                SmokeResult.Text = "Вам следует обратиться в кабинет по отказу от курения";
            }
        }

        private void SendEmail_Click(object sender, RoutedEventArgs e)
        {
            Start_Page.timer.Stop();
            App.MContent.Content = new SendEmail();
        }

        private void BackToMainPage_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void BigDiag_Click(object sender, RoutedEventArgs e)
        {
            App.countUserC++;
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }
    }
}
