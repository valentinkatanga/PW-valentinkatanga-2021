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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for kffr.xaml
    /// </summary>
    public partial class kffr : Window
    {
        MainWindow _main;
        public kffr(MainWindow main)
        {
            InitializeComponent();
            _main = main;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtBoxanswer.Text.ToLower() == "dobbelsteen" || txtBoxanswer.Text.ToLower() == "een dobbelsteen")
            {
                _main.operationC();

                this.Close();
            }
            else
            {
                lblAnswer.Content = "Fout";
            }
        }


    }
}
