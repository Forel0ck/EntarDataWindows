using System;
using System.Collections.Generic;
using System.IO;
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

namespace MassegBox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void Age_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void FName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void LName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void btEntry_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\user\Desktop\mes.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(FName.Text);
                sw.Write(LName.Text);
                sw.Write(Age.Text);
                sw.Close();
            }


            MessageBox.Show($"Имя: {LName.Text}  Фамилия: {FName.Text}  Возраст: {Age.Text}");
        }
    }
}
