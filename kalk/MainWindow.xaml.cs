using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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

namespace kalk
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Variables
        {
            public static string display { get; set; }

            public static string operace { get; set; }

            public static bool operaceZmacknuto { get; set; }

            public static int cislo  { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();

        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            string BtnName;
            BtnName = (sender as System.Windows.Controls.Button).Content.ToString();


            

            displayer.Content = displayer.Content + BtnName;
        }

        
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(displayer.Content.ToString(), "");

            displayer.Content = v.ToString();
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
