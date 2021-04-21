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
using System.Windows.Threading;





namespace WpfApp1
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
        

        private void btnHint_Click(object sender, RoutedEventArgs e)
        {
            txtBoxmsg.Text = "Vincent Van Gogh";
            
        }

        private void btnTapijt_Click(object sender, RoutedEventArgs e)
        {

            btnTapijt.Content = "Dit is een oude tapijt.";
            btnZetel.Content = "";
            btnBord.Content = "";
            btnhorloge.Content = "";
            btnBoekenkast.Content = "";
            btnStoel.Content = "";
            btnTafel.Content = "";
            btnKastje.Content = "";
            btnAardbol.Content = "";
        }

        private void btnBord_Click(object sender, RoutedEventArgs e)
        {


            btnTapijt.Content = "";
            btnZetel.Content = "";
            btnBord.Content = "";
            btnhorloge.Content = "";
            btnBoekenkast.Content = "";
            btnStoel.Content = "";
            btnTafel.Content = "";
            btnKastje.Content = "";
            btnAardbol.Content = "";
            kffr koffer = new kffr();
            koffer.Show();
        }

        private void btnhorloge_Click(object sender, RoutedEventArgs e)
        {

            btnTapijt.Content = "";
            btnZetel.Content = "";
            btnBord.Content = "";
            btnhorloge.Content = "'t Is 23 uur";
            btnBoekenkast.Content = "";
            btnStoel.Content = "";
            btnTafel.Content = "";
            btnKastje.Content = "";
            btnAardbol.Content = "";
        }

        private void btnBoekenkast_Click(object sender, RoutedEventArgs e)
        {

            btnTapijt.Content = "";
            btnZetel.Content = "";
            btnBord.Content = "";
            btnhorloge.Content = "";
            btnBoekenkast.Content = "Veel boeken";
            btnStoel.Content = "";
            btnTafel.Content = "";
            btnKastje.Content = "";
            btnAardbol.Content = "";

        }

        private void btnStoel_Click(object sender, RoutedEventArgs e)
        {
  
            btnTapijt.Content = "";
            btnZetel.Content = "";
            btnBord.Content = "";
            btnhorloge.Content = "";
            btnBoekenkast.Content = "";
            btnStoel.Content = "Geen tijd om te zitten";
            btnTafel.Content = "";
            btnKastje.Content = "";
            btnAardbol.Content = "";
        }

        private void btnTafel_Click(object sender, RoutedEventArgs e)
        {

            btnTapijt.Content = "";
            btnZetel.Content = "";
            btnBord.Content = "";
            btnhorloge.Content = "";
            btnBoekenkast.Content = "";
            btnStoel.Content = "";
            btnTafel.Content = "Er ligt een assenbak op tafel.";
            btnKastje.Content = "";
            btnAardbol.Content = "";

        }

        private void btnZetel_Click(object sender, RoutedEventArgs e)
        {

            btnZetel.Content = "Ik zou willen liggen op de zetel";
            btnTapijt.Content = "";
            btnBord.Content = "";
            btnhorloge.Content = "";
            btnBoekenkast.Content = "";
            btnStoel.Content = "";
            btnTafel.Content = "";
            btnKastje.Content = "";
            btnAardbol.Content = "";


        }

        private void btnKastje_Click(object sender, RoutedEventArgs e)
        {
            
            txtBoxmsg.Text = txtBoxmsg.Text + "\n" + "Ik heb de kogels gevonden voor het wapen";
            btnTapijt.Content = "";
            btnZetel.Content = "";
            btnBord.Content = "";
            btnhorloge.Content = "";
            btnBoekenkast.Content = "";
            btnStoel.Content = "";
            btnTafel.Content = "";
            btnKastje.Content = "";
            btnAardbol.Content = "";
            imgLoad.Opacity = 1;
        }

        private void btnAardbol_Click(object sender, RoutedEventArgs e)
        {
            txtBoxmsg.Text = "";
            btnTapijt.Content = "";
            btnZetel.Content = "";
            btnBord.Content = "";
            btnhorloge.Content = "";
            btnBoekenkast.Content = "";
            btnStoel.Content = "";
            btnTafel.Content = "";
            btnKastje.Content = "";
            btnAardbol.Content = "Een aardbol";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            //DispatcherTimer dispatcherTimer = new DispatcherTimer();
            //dispatcherTimer.Tick -= new EventHandler(dispatcherTimerTick);
            //dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            //dispatcherTimer.Start();
            imgBack.Opacity = 1;




        }
        //private void dispatcherTimerTick(object sender, EventArgs e)
        //{
        //    double seconds = 30;
        //    txtbxTime.Text = Convert.ToDateTime (seconds);

     
        //    CommandManager.InvalidateRequerySuggested();
        //}

        private void btnNxtlvl_Click(object sender, RoutedEventArgs e)
        {
            lvl2 level2 = new lvl2();
            level2.Show();
        }
    }
}
