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
    public sealed partial class DetaljiPotrosaca : Page
    {
        private DetaljiPotrosacaViewModel dpvm = new DetaljiPotrosacaViewModel();
        Potrosac trenutni = new Potrosac();
        private string navigacija;
        

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            trenutni = (Potrosac)e.Parameter;
            dpvm.Trenutni = trenutni;
            dpvm.popuni();
        }

        public DetaljiPotrosaca()
        {
            dpvm = new DetaljiPotrosacaViewModel();
            this.DataContext = dpvm;
            this.InitializeComponent();
        }

        private void bNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdministratorOpcije));
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
    }
}
