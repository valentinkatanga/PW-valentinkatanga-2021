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
        public void operationA()
        {
            imgPistol.Opacity = 3.5;
            lblBoxmsg.Content = lblBoxmsg.Content + "\n" + "Ik heb het wapen gevonden! (klik erop)";

        }
        public void operationB()
        {
            lblBoxmsg.Content = "Uw code voor de volgende kamer is Good";
            if(imgH1.Opacity == 0.2)
            {
            lblBoxmsg.Content = "Uw code voor de volgende kamer is Calm";
            }
            if (imgH1.Opacity == 0.2 && imgH2.Opacity == 0.2)
            {
                lblBoxmsg.Content = "Uw code voor de volgende kamer is Stressful";
            }
            if (imgH1.Opacity == 0.2 && imgH2.Opacity == 0.2 && imgH3.Opacity == 0.2)
            {
                lblBoxmsg.Content = "Uw code voor de volgende kamer is Dead";
            }



        }
        int count = 0;
        private void btnHint_Click(object sender, RoutedEventArgs e)
        {
            count++;
            
            switch (count)
            {
                case 1: imgH1.Opacity = 0.2;
                lblBoxmsg.Content = "Hint 1: Van Gogh Vincent";
                    break;
                case 2: imgH2.Opacity = 0.2;
                    lblBoxmsg.Content = "Hint 2: Shoppingsite";
                    break;
                default:
                    imgH3.Opacity = 0.2;
                    lblBoxmsg.Content = "Hint 3: ibé ";
                    btnHint.IsEnabled = false;

                    break;
            }
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
            kffr koffer = new kffr(this);
            koffer.Show();
        }

        private void btnhorloge_Click(object sender, RoutedEventArgs e)
        { 
            btnBord.Content = "";
            btnZetel.Content = "";
            btnStoel.Content = "";
            btnTafel.Content = "";
            btnTapijt.Content = "";
            btnKastje.Content = "";
            btnAardbol.Content = "";
            btnBoekenkast.Content = "";
            btnhorloge.Content = "'t Is 23 uur";
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

            btnTapijt.Content = "";
            btnZetel.Content = "";
            btnBord.Content = "";
            btnhorloge.Content = "";
            btnBoekenkast.Content = "";
            btnStoel.Content = "";
            btnTafel.Content = "";
            btnKastje.Content = "";
            btnAardbol.Content = "";
            btnKastje.Content = "Juwelen";
        }

        private void btnAardbol_Click(object sender, RoutedEventArgs e)
        {
            lblBoxmsg.Content = "";
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
            imgBack.Opacity = 0.9;
            btnHint.IsEnabled = true;
            btnStart.IsEnabled = false;
        }


        public void btnNxtlvl_Click(object sender, RoutedEventArgs e)
        {
            lvl2 level2 = new lvl2(this);
            level2.Show();
        }
    }

}
