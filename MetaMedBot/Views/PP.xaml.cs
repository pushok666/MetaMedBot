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
    /// Interaction logic for PP.xaml
    /// </summary>
    public partial class PP : UserControl
    {
        private string sex;
        public PP()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            App.countUserC--;
            //App.initPerson = null;
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }

        private void Men_Checked(object sender, RoutedEventArgs e)
        {
            WomenRadio.IsChecked = false;
            sex = ManRadio.Content.ToString();
        }

        private void Femen_Checked(object sender, RoutedEventArgs e)
        {
            ManRadio.IsChecked = false;
            sex = WomenRadio.Content.ToString();
        }

        private void AgeTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            int check = 0;
            if (sender != null)
            {
                if (int.TryParse(AgeTB.Text, out check))
                {
                    if (check > 150)
                    {
                        AgeTB.Text = null;
                        MessageBox.Show("не может быть такого");
                    }
                    else
                    {
                        AgeTB.Text = AgeTB.Text;
                    }
                }
                else
                {
                    AgeTB.Text = null;
                    MessageBox.Show("Вводить можно только числа");

                }
            }
            
        }

        private void WeightTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            int check = 0;
            if (sender != null)
            {
                if (int.TryParse(WeightTB.Text, out check))
                {
                    if (check > 500)
                    {
                        WeightTB.Text = null;
                        MessageBox.Show("не может быть такого");
                    }
                    else
                    {
                        WeightTB.Text = WeightTB.Text;
                    }
                }
                else
                {
                    WeightTB.Text = null;
                    MessageBox.Show("Вводить можно только числа");

                }
            }
        }

        private void GrowthTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            int check = 0;
            if (sender != null)
            {
                if (int.TryParse(GrowthTB.Text, out check))
                {
                    if (check > 300)
                    {
                        GrowthTB.Text = null;
                        MessageBox.Show("не может быть такого");
                    }
                    else
                    {
                        GrowthTB.Text = GrowthTB.Text;
                    }
                }
                else
                {
                    GrowthTB.Text = null;
                    MessageBox.Show("Вводить можно только числа");

                }
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (AgeTB.Text == "" || WeightTB.Text == "" || GrowthTB.Text == "")
            {
                MessageBox.Show("Введите данные");
                return;
            }
            App.PropertyPerson.Sex = sex;
            App.PropertyPerson.Age = Convert.ToInt32(AgeTB.Text);
            App.PropertyPerson.Growth = Convert.ToInt32(GrowthTB.Text);
            App.PropertyPerson.Weight = Convert.ToInt32(WeightTB.Text);
            App.countUserC++;
            App.MContent.Content = MainWindow.userControls[App.countUserC];
        }
    }
}
