using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Posta.ViewModel;
using System.ComponentModel;
using Posta.Model;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Posta.Forms
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LogIn : Page, INotifyPropertyChanged
    {
        public LoginViewModel lvm { get; set; } = new LoginViewModel();
        

        public LogIn()
        {
            this.InitializeComponent();
            //hardkodirani
            Potrosac selma = new Model.Potrosac("Selma", "Vucijak", "062316446", "Logavina", "2307997175013", "selmav", "selma", DateTime.Today);
            selma.DodajRacun(new Model.Racun(1, 1, true));
            selma.DodajRacun(new Model.Racun(2, 2, false));
            ePosta.Instanca.dodajPotrosaca(selma);
            ePosta.Instanca.dodajUposlenika(new Salterusa("ilmas", "ilma"));
            ePosta.Instanca.dodajUposlenika(new Postar("faruks", "faruk"));
            ePosta.Instanca.dodajUposlenika(new Administrator());
            
            this.DataContext = lvm;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void bLogin_Click(object sender, RoutedEventArgs e)
        {
            var osobaP = lvm.validateP();
            var osobaU = lvm.validateU();
            if(osobaP != null)
            {
                //ulogovao potrosac
                porukaGreske.Visibility = Visibility.Collapsed;
                GlavniFrame.Navigate(typeof(OpcijePotrosaca), osobaP);
            }
            else
            {
                if(osobaU != null)
                {
                    porukaGreske.Visibility = Visibility.Collapsed;
                    //ulogovao uposlenik
                    if (osobaU is Salterusa)
                        GlavniFrame.Navigate(typeof(OpcijeSalter), osobaU);
                    else if (osobaU is Postar)
                        GlavniFrame.Navigate(typeof(FormaPostara), osobaU);
                    else if (osobaU is Administrator)
                        GlavniFrame.Navigate(typeof(AdministratorOpcije), osobaU);
                }
                else
                {
                    porukaGreske.Visibility = Visibility.Visible;
                }
            }
        }
        
        private void bRegistrujSe_Click(object sender, RoutedEventArgs e)
        {
            GlavniFrame.Navigate(typeof(RegistracijaUposlenika), this.DataContext);
        }

    }
}
