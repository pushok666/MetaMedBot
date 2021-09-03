using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Net;
using System.IO;
using System.Net.Mail;

namespace MetaMedBot.Views
{
    /// <summary>
    /// Interaction logic for SendEmail.xaml
    /// </summary>
    public partial class SendEmail : UserControl
    {
        string email = "";
        public SendEmail()
        {
            InitializeComponent();
        }

        private void TextBlock_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var myTextBox = (TextBox)sender;
            email = myTextBox.Text;
           
            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            bool result = ValidatorExtensions.IsValidEmailAddress(email);
            if(result == true)
            {
                MailAddress from = new MailAddress("BoozerMedRobot@yandex.ru", "Doctor");
                // кому отправляем
                MailAddress to = new MailAddress(email);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Анализы";
                m.Body = "<h2> ваши анализы</h2>";
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
                smtp.Credentials = new NetworkCredential(@"BoozerMedRobot@yandex.ru", @"Robot12345");
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                
                smtp.Send(m);
                MessageBox.Show("Отравленно");
                App.MContent.Content = MainWindow.userControls[App.countUserC];
            }
            else
            {
                MessageBox.Show("email введен неправильно");
            }
            
        }
    }

    public static class ValidatorExtensions
    {
        public static bool IsValidEmailAddress(this string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }
    }
}
