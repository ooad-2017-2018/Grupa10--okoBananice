using Posta.Model;
using Posta.ViewModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Posta.Forms
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistracijaPotrosaca : Page, INotifyPropertyChanged
    {
        Uposlenik trenutni;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            trenutni = (Uposlenik)e.Parameter;
        }
        public RegistracijaPotrosacaViewModel rpvm { get; set; } = new RegistracijaPotrosacaViewModel();
        public RegistracijaPotrosaca()
        {
            this.InitializeComponent();
            this.DataContext = rpvm;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void CalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            DateTimeOffset what = kalendar.Date.Value; 
            rpvm.DatumRodjenja = what.DateTime;
        }
        private void bNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpcijeSalter), trenutni);
        }
    }
}
