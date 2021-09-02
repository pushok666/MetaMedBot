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
    /// Interaction logic for IP.xaml
    /// </summary>
    public partial class IP : UserControl
    {
        public IP()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SurnameTB.Text != "" && NameTB.Text != ""&& PatronymicTB.Text != "")
            {
                App.initPerson.Surname = SurnameTB.Text;
                App.initPerson.Name = NameTB.Text;
                App.initPerson.Patronymic = PatronymicTB.Text;
                App.countUserC++;
                App.MContent.Content = MainWindow.userControls[App.countUserC];
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
            
        }

        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char inp = e.Text[0];
            if (inp < 'А' || inp > 'я')
                e.Handled = true;
        }

        private void TextBox_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back || e.Key == Key.Space)
                e.Handled = true;
        }

        private void SurnameTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            /* int check = 0;
             if (SurnameTB.Text != null)
             {
                 if (int.TryParse(SurnameTB.Text, out check))
                 {
                     SurnameTB.Text = null;
                     MessageBox.Show("Вы ввели чило");
                 }
                 else
                 {
                     if (SurnameTB.Text.Length > 255)
                     {
                         MessageBox.Show("строка очень большая");
                     }
                     else
                     {
                         SurnameTB.Text = SurnameTB.Text;
                     }
                 }
             }
             else
             {
                 MessageBox.Show("Введите свои данные");
             }
            */
            
            
                char[] text = SurnameTB.Text.ToCharArray();
                foreach (var t in text)
                {
                    if ((int)t >= 192 && (int)t <= 255)
                    {
                        SurnameTB.Text = SurnameTB.Text;
                    }
                    else
                    {
                        MessageBox.Show("Вы введи не корректные данные");
                        SurnameTB.Text = null;
                    }
                }
                
            
        }

        private void NameTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            int check = 0;
            if (NameTB.Text != null)
            {
                if (int.TryParse(NameTB.Text, out check))
                {
                    NameTB.Text = null;
                    MessageBox.Show("Вы ввели чило");
                }
                else
                {
                    if (NameTB.Text.Length > 255)
                    {
                        MessageBox.Show("строка очень большая");
                    }
                    else
                    {
                        NameTB.Text = NameTB.Text;
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите свои данные");
            }
        }

        private void PatronymicTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            int check = 0;
            if (PatronymicTB.Text != null)
            {
                if (int.TryParse(PatronymicTB.Text, out check))
                {
                    PatronymicTB.Text = null;
                    MessageBox.Show("Вы ввели чило");
                }
                else
                {
                    if (PatronymicTB.Text.Length > 255)
                    {
                        MessageBox.Show("строка очень большая");
                    }
                    else
                    {
                        PatronymicTB.Text = PatronymicTB.Text;
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите свои данные");
            }
        }
    }
}
