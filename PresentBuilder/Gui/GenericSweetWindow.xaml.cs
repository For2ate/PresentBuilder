using PresentBuilder.DataLayer.DataClasses;
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
using System.Windows.Shapes;
using static PresentBuilder.DataLayer.DataClasses.Sweet;

namespace PresentBuilder.Gui
{
    /// <summary>
    /// Логика взаимодействия для GenericSweetWindow.xaml
    /// </summary>
    public partial class GenericSweetWindow : Window
    {
        public GenericSweetWindow()
        {
            InitializeComponent();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBoxType.Foreground = Brushes.DarkSlateGray;
            if (comboBoxType.SelectedIndex == 0)
            {
                innerTypeBox.Text = "Выберите тип конфеты";
                innerTypeBox.ItemsSource = new string[] {
                    "шоколадная",
                     "желейная",
                     "фруктовая",
                      "ирис"
                };
            } else
            {
                innerTypeBox.Text = "Выберите тип печенья";
                innerTypeBox.ItemsSource = new string[] {
                    "шоколадное",
                     "с орехами",
                     "фруктовое",
                };
            }
        }
        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox)
            {
                if (sender is TextBox)
                {
                    hintNameTextBox.Foreground = Brushes.DarkSlateGray;
                    hintNameTextBox.Visibility = ((sender as TextBox).Text.Length == 0 ? Visibility.Visible : Visibility.Hidden);
                }
            } 
        }
        private void weight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(sender is TextBox)
            {
                hintWeightTextBox.Foreground = Brushes.DarkSlateGray;
                hintWeightTextBox.Visibility = ((sender as TextBox).Text.Length == 0 ? Visibility.Visible : Visibility.Hidden);
            }
        }

        private void sugarPecent_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            hintSugarPersent.Text = $"Процент сахара в сладости {Convert.ToInt32((sender as Slider).Value)} %";
        }

        private void addSweets_Click(object sender, RoutedEventArgs e)
        {
            string name = "", weight = "", type = "", innerType = "";
            int sugarPecent = Convert.ToInt32(sugarPecentSlider.Value);
            if (nameTextBox.Text == "")
            {
                hintNameTextBox.Text = "Вы не ввели название";
                hintNameTextBox.Foreground = Brushes.Red;
            }
            else
            {
                name = nameTextBox.Text;
            }
            if (weightTextBox.Text == "") {
                hintWeightTextBox.Text = "Вы не ввели вес";
                hintWeightTextBox.Foreground = Brushes.Red;
            }
            else
            {
                bool isDigit = true;
                foreach (char i in weightTextBox.Text)
                {
                    if (Char.IsDigit(i) == false) {
                        isDigit = false;
                        break;
                    }
                }
                if (isDigit == false)
                {
                    weightTextBox.Text = "";
                    hintWeightTextBox.Text = "Вы ввели не число";
                    hintWeightTextBox.Foreground = Brushes.Red;
                } else
                {
                    weight = weightTextBox.Text;
                }
            }
            if (comboBoxType.Text == "Выберите тип сладости")
            {
                comboBoxType.Foreground = Brushes.Red;
            } else
            {
                type = comboBoxType.SelectedItem.ToString();
            }

            if (type != "" && innerTypeBox.Text != "Выберите тип сладости")
            {
                innerType = innerTypeBox.Text;
            }

            if (type != "" && innerType != "" && weight != "" && name != "")
            {
                if (type == "Печенька")
                {
                    Sourse.AddNewElement(new Cookie(Convert.ToInt32(weight), sugarPecent, name, innerType));
                }
                else
                {
                    Sourse.AddNewElement(new Sweet(Convert.ToInt32(weight), sugarPecent, name, innerType));
                }
                genericWindow.Close();
            }

        }
    }
}
