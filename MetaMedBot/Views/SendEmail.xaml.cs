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

namespace MetaMedBot.Views
{
    /// <summary>
    /// Interaction logic for SendEmail.xaml
    /// </summary>
    public partial class SendEmail : UserControl
    {
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
            bool result = ValidatorExtensions.IsValidEmailAddress(myTextBox.Text);
            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Отравленно");
            App.MContent.Content = MainWindow.userControls[App.countUserC];
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
