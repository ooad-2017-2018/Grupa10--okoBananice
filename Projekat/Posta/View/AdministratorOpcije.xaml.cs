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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Posta.Forms
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdministratorOpcije : Page
    {
        private Potrosac trazeni;
        private AdministratorViewModel avm;

        public AdministratorOpcije()
        {
            this.InitializeComponent();
            avm = new AdministratorViewModel();
            this.DataContext = avm;
        }

        private void textBox_TextChanged(System.Object sender, TextChangedEventArgs e)
        {

        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LogIn), this.DataContext);
        }

        private void bPodaciPotrosaca_Click(object sender, RoutedEventArgs e)
        {
            //implementirati pretragu
            this.Frame.Navigate(typeof(DetaljiPotrosaca), avm.Trazeni);
        }
        private void bObrisiPotrosaca_Click(object sender, RoutedEventArgs e)
        {
            //implementirati pretragu
            //brisanje iz liste i baze
        }

        private void bPrikazRacuna_Click(object sender, RoutedEventArgs e)
        {
            //implementirati pretragu
            this.Frame.Navigate(typeof(PregledRacuna), avm.Trazeni);
        }
    }
}
