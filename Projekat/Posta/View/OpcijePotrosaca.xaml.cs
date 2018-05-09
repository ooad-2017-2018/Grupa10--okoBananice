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
    public sealed partial class OpcijePotrosaca : Page
    {
        Potrosac trenutni;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            trenutni = (Potrosac)e.Parameter;
        }

        public OpcijePotrosaca()
        {
            this.InitializeComponent();
        }

        private void bPregledRacuna_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PregledRacuna), trenutni);
        }

        private void bPracenjePaketa_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PracenjePaketa), this.DataContext);
        }

        private void bShop_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Shop), this.DataContext);
        }

        private void bLogOut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LogIn), this.DataContext);
        }
    }
}
