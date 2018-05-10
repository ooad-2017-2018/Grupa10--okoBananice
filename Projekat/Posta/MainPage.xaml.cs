using Posta.Forms;
using Posta.Model;
using Posta.ViewModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Posta
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }
            
          /*  Potrosac selma = new Model.Potrosac("Selma", "Vucijak", "062316446", "Logavina", "2307997175013", "selmav", "selma", DateTime.Today);
            selma.DodajRacun(new Model.Racun(1, 1, true));
            selma.DodajRacun(new Model.Racun(2, 2, false));
            ePosta.Instanca.dodajPotrosaca(selma);
            Potrosac faruk = new Model.Potrosac("F", "S", "365665", "Logavina", "12346789", "fsm", "etf", DateTime.Today);
            faruk.DodajRacun(new Model.Racun(1, 1, true));
            faruk.DodajRacun(new Model.Racun(2, 2, false));
            ePosta.Instanca.dodajPotrosaca(faruk);
            ePosta.Instanca.dodajUposlenika(new Salterusa("ilmas", "ilma"));
            ePosta.Instanca.dodajUposlenika(new Postar("faruks", "faruk"));
            ePosta.Instanca.dodajUposlenika(new Administrator());
            
        }
        private void prebaci()
        {
            this.Frame.Navigate(typeof(LogIn));

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            prebaci();
        }
        */
    }
}
