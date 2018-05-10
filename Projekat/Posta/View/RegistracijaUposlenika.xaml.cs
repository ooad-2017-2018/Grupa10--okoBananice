using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Posta.Model;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Posta.Forms
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistracijaUposlenika : Page, INotifyPropertyChanged
    {
        public RegistracijaUposlenikaViewModel regUpo { get; set; } = new RegistracijaUposlenikaViewModel();
        public RegistracijaUposlenika()
        {
            this.InitializeComponent();
            this.DataContext = regUpo;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)

        {
            

        }
        private void textBox_TextChanged(System.Object sender, TextChangedEventArgs e)
        {

        }
        private void bNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LogIn), this.DataContext);
        }

        private void bRegistracijaU_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
