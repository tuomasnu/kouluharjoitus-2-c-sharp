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

namespace Valinta
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

        private void btnNopeus_Click(object sender, RoutedEventArgs e)
        {
            int nopeus = 0;
            txbNopeus.Text = "";
            
            nopeus = int.Parse(txtNopeus.Text);
            if (nopeus > 120)
            {
                txbNopeus.Text = "Ylinopeus!";
            }
            else
            {
                txbNopeus.Text = "Jatkakaa..";
            }
        }

        private void btnVuosi_Click(object sender, RoutedEventArgs e)
        {
            int vuosi = 0;
            txbVuosi.Text = "";
                
            vuosi = int.Parse(txtVuosi.Text);
            if (vuosi == 2000)
            {
                txbVuosi.Text = "Vuosisata vaihtui";
            }
            else
            {
                txbVuosi.Text = "Selvä";
            }
        }

        private void btnLuku_Click(object sender, RoutedEventArgs e)
        {
            double luku = double.Parse(txtLuku.Text);

            txbLuku.Text = "";
            if (luku < 0)
            {
                txbLuku.Text = "negatiivinen luku";
            }
            else
            {
                txbLuku.Text = "positiivinen luku";
            }
        }

        private void btnPortsari_Click(object sender, RoutedEventArgs e)
        {
            int ikä = 0;
            txbPortsari.Text = "";

            ikä = int.Parse(txtIkä.Text);
            if (ikä < 18)
            {
                txbPortsari.Text = "Alaikäinen";
            }
            else
            {
                txbPortsari.Text = "Täysi-ikäinen";
            }
        }

        private void btnSuurempi_Click(object sender, RoutedEventArgs e)
        {
            int luku1 = 0;
            int luku2 = 0;
            txbSuurempi.Text = "";

            luku1 = int.Parse(txtLuku1.Text);
            luku2 = int.Parse(txtLuku2.Text);

            if (luku1 > luku2)
            {
                txbSuurempi.Text = "Suurempi luku on " + luku1;
            }
            else
            {
                txbSuurempi.Text = "Suurempi luku on " + luku2;
            }
        }

        private void btnLaske_Click(object sender, RoutedEventArgs e)
        {
           int luku1 = 0;
           int luku2 = 0;
           txbTulos.Text = "";

           luku1 = int.Parse(txtLuku1.Text);
           luku2 = int.Parse(txtLuku2.Text);

           int tulo = luku1 * luku2;
           if (tulo < 0)
            {
                txbTulos.Text = "Toinen luvuista on negatiivinen";
            } 
           else
            {
                txbTulos.Text = "Molemmat luvut ovat positiivisia tai negatiivisia";
            }
        }

        private void btnNumero1_Click(object sender, RoutedEventArgs e)
        {
            int numero = 0;
            int jakoj = 0;
            txbNumero1.Text = "";

            numero = int.Parse(txtNumero.Text);
            jakoj = numero % 2;

            if (jakoj == 0)
            {
                txbNumero1.Text = "parillinen";
            }
            else
            {
                txbNumero1.Text = "pariton";
            }
        }

        private void btnNumero2_Click(object sender, RoutedEventArgs e)
        {
            int numero = 0;
            txbNumero2.Text = "";

            numero = int.Parse(txtNumero.Text);
            if (numero < 0)
            {
                txbNumero2.Text = "Negatiivinen";
            }
            else if (numero > 0)
            {
                txbNumero2.Text = "Positiivinen";
            }
            else
            {
                txbNumero2.Text = "Nolla";
            }
        }

        private void btnSivu_Click(object sender, RoutedEventArgs e)
        {
            int sivu1 = 0;
            int sivu2 = 0;
            txbSivu.Text = "";

            sivu1 = int.Parse(txtSivu1.Text);
            sivu2 = int.Parse(txtSivu2.Text);

            if (sivu1 == sivu2)
            {
                txbSivu.Text = "Neliö";
            }
            else
            {
                txbSivu.Text = "Suorakaide";
            }
        }

        private void btnPisteet_Click(object sender, RoutedEventArgs e)
        {
            int pisteet = 0;
            txbPisteet.Text = "";

            pisteet = int.Parse(txtPisteet.Text);
            if (pisteet <= 29)
            {
                txbPisteet.Text = "Hylätty";
            }
            else if (pisteet <= 34)
            {
                txbPisteet.Text = "Välttävä";
            }
            else if (pisteet <= 39)
            {
                txbPisteet.Text = "Tyydyttävä";
            }
            else if (pisteet <= 49)
            {
                txbPisteet.Text = "Hyvä";
            }
            else
            {
                txbPisteet.Text = "Kiitettävä";
            }
        }

        private void btnKello_Click(object sender, RoutedEventArgs e)
        {
            int kello = 0;
            txbKello.Text = "";

            kello = int.Parse(txtKello.Text);
            if (kello >= 20)
            {
                txbKello.Text = "Hyvää yötä";
            }
            if (kello >= 18)
            {
                txbKello.Text = "Hyvää iltaa";
            }
            else if (kello >= 12)
            {
                txbKello.Text = "Hyvää iltapäivää";
            }
            else if (kello >= 4)
            {
                txbKello.Text = "Hyvää huomenta";
            }
            else
            {
                txbKello.Text = "Hyvää yötä";
            }
        }


        private void btnKarkausvuosi_Click(object sender, RoutedEventArgs e)
        {
            int vuosi = 0;
            txbKarkausvuosi.Text = "";

            vuosi = int.Parse(txtKarkausvuosi.Text);

            if (vuosi % 4 == 0)
            {
                if (vuosi % 100 == 0)
                {
                    if (vuosi % 400 == 0)
                    {
                        txbKarkausvuosi.Text = "on karkausvuosi 1";
                    }
                    else
                    {
                        txbKarkausvuosi.Text = "ei ole karkausvuosi 1";
                    }
                }
                else
                {
                    txbKarkausvuosi.Text = "on karkausvuosi 2";
                }
            }
            else
            {
                txbKarkausvuosi.Text = "ei ole karkausvuosi 2";
            }
        }

        private void btnKarkausvuosi2_Click(object sender, RoutedEventArgs e)
        {
            int vuosi = 0;
            txbKarkausvuosi2.Text = "";

            vuosi = int.Parse(txtKarkausvuosi.Text);

            if (DateTime.IsLeapYear(vuosi))
            {
                txbKarkausvuosi2.Text = "on karkausvuosi";
            }
            else
            {
                txbKarkausvuosi2.Text = "ei ole karkausvuosi";
            }
        }

        private void btnTeksti_Click(object sender, RoutedEventArgs e)
        {
            if (txtTeksti.Text == "totta")
            {
                txbTeksti.Text = "Oikein";
            }
            else
            {
                txbTeksti.Text = "yritä uudestaan";
            }

        }

        private void btnTunnus_Click(object sender, RoutedEventArgs e)
        {
            if (txtTunnus.Text == "antero" && txtSalasana.Password == "SAL45.2!")
            {
                txbTunnus.Text = "Olet kirjautunut järjestelmään";
            }
            else if (txtTunnus.Text == "elina" && txtSalasana.Password == "23.5.kmi")
            {
                txbTunnus.Text = "Olet kirjautnut järjestelmään";
            }
            else
            {
                txbTunnus.Text = "Käyttäjätunnus tai salasana on väärin";
            }
        }

    }
}
