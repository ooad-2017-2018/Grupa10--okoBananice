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
            avm.Found = false;
            this.DataContext = avm;
        }

        /*protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.DataContext = avm;
            avm.Found = false;
        }*/


        private void textBox_TextChanged(System.Object sender, TextChangedEventArgs e)
        {

        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LogIn), this.DataContext);
        }

        private void bPodaciPotrosaca_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DetaljiPotrosaca), trazeni);

        }
        private void bObrisiPotrosaca_Click(object sender, RoutedEventArgs e)
        {
            //implementirati pretragu
            //brisanje iz baze
            

        }

        private void bPrikazRacuna_Click(object sender, RoutedEventArgs e)
        {
            //implementirati pretragu
            List<object> parametri = new List<object>();
            parametri.Add(avm.Trazeni);
            parametri.Add("Admin");
            this.Frame.Navigate(typeof(PregledRacuna), parametri);
        }
    }
}
