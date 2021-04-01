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

    public partial class MainWindow : Window
    {
        string path = @"C:\Users\user\Desktop\mes.txt";
        List<People> peopleList = new List<People>();

        public MainWindow()
        {
            InitializeComponent();


        }


        private void txtAge_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void txtFName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void txtLName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void btEntry_Click(object sender, RoutedEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(txtFName.Text);
                sw.Write(";");
                sw.Write(txtLName.Text);
                sw.Write(";");
                sw.Write(txtAge.Text);
                sw.Write(";");
                sw.Close();
            }


            MessageBox.Show($"Имя: {txtLName.Text}  Фамилия: {txtFName.Text}  Возраст: {txtAge.Text}");

        }

        private void btView_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
            NEXT next = new NEXT();
            next.ShowDialog();
            this.Show();
        }
    }
}
