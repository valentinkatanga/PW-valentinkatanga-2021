using Microsoft.Win32;
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

namespace WpfApp2
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
            int count = 0;
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

 
                count++;

                switch (count)
                {
                    case 1:
                    imgNeo.Opacity = 1;
                    imgMorph.Opacity = 0;
                    txtBlcka.Text = "Urgh, waar ben ik?!";
                        break;
                    case 2:
                        txtBlckb.Text = "Welkom in de Escape room";
                        txtBlcka.Text = "";
                    imgNeo.Opacity = 0;
                    imgMorph.Opacity = 1;
                    break;
                case 3:
                    txtBlcka.Text = "De Escape room? Wat is deze plaats?";
                    txtBlckb.Text = "";
                    imgNeo.Opacity = 1;
                    imgMorph.Opacity = 0;
                    break;
                case 4:
                    txtBlckb.Text = "De Escape room is de plaats waarin virtualiteit en mentaliteit één vormen" + "\n" + "Om uw waarde te bewijzen, zal u moeten deelnemen aan het project" + "\n" + "ESCAPE OR DIE";
                    txtBlcka.Text = "";
                    imgNeo.Opacity = 0;
                    imgMorph.Opacity = 1;
                    break;
                case 5:
                    txtBlcka.Text = "Wat houdt dat in?";
                    txtBlckb.Text = "";
                    imgNeo.Opacity = 1;
                    imgMorph.Opacity = 0;
                    break;
                case 6:
                    txtBlcka.Text = "";
                    txtBlckb.Text = "U zal moeten ontsnappen van 5 kamers binnen een korte tijdsperiode";
                    imgMorph.Opacity = 1;
                    imgNeo.Opacity = 0;
                    break;
                case 7:
                    txtBlcka.Text = "Het zal me geen moeite kosten om te ontsnappen";
                    txtBlckb.Text = "";
                    imgNeoG.Opacity = 1;
                    imgMorph.Opacity = 0;
                    break;
                case 8:
                    txtBlcka.Text = "";
                    txtBlckb.Text = "Dat zullen we zien, hehehe... Veel succes";
                    imgMorphS.Opacity = 1;


                    break;
                case 9:
                    this.Close();
                    break;

                default:
                        break;
                }
            
        }

        
    }

}
