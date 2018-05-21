using Posta.Model;
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
    public sealed partial class OpcijeSalter : Page
    {
        Uposlenik trenutni;

        public OpcijeSalter()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            trenutni = (Uposlenik)e.Parameter;
        }

        private void bRegistracijaPotrosaca_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegistracijaPotrosaca), trenutni);
        }

        private void bLogOut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LogIn), this.DataContext);
        }

    }
}
