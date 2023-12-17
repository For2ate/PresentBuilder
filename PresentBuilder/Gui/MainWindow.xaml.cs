using PresentBuilder;
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
using PresentBuilder.Gui;
using PresentBuilder.DataLayer.DataClasses;

namespace PresentBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addSweetsButton_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine("Hello");
            GenericSweetWindow genericSweetWindow = new GenericSweetWindow();
            genericSweetWindow.Show();
        }

        public void AddInWindow(Sweets obj)
        {
            if (obj is Sweet)
            {
                presentListView.Items.Add((obj as Sweet).ToString());
            }
            else
            {
                presentListView.Items.Add((obj as Cookie).ToString());
            }
        }

    }
}
