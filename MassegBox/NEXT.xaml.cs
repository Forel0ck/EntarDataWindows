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
using System.Windows.Shapes;

namespace MassegBox
{

    public partial class NEXT : Window
    {
        string path = @"C:\Users\user\Desktop\mes.txt";

        List<People> peopleList = new List<People>();


        public NEXT()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < File.ReadLines(path).Count(); i++)
                {
                    string str = sr.ReadLine();

                    if (str.ToString().Length > 7)
                    {
                        Console.WriteLine(str);
                    }
                }
            }

        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
