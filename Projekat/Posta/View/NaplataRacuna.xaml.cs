using Posta.Model;
using Posta.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class NaplataRacuna : Page, INotifyPropertyChanged
    {
        private Potrosac trenutni;
        private NaplataRacunaViewModel nrvm;
        private Uposlenik trenutniUposlenik;
        private ObservableCollection<Racun> r;

        public ObservableCollection<Racun> R
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
                OnPropertyChanged("R");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        

        public NaplataRacuna()
        {
            this.InitializeComponent();
            nrvm = new NaplataRacunaViewModel();
            r = new ObservableCollection<Racun>();
            listView.ItemsSource = r;
            this.DataContext = nrvm;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            List<object> parametri = (List<object>)e.Parameter;
            trenutniUposlenik = (Uposlenik)parametri[0];
            trenutni = (Potrosac)parametri[1];
            foreach (Racun i in trenutni.sviRacuni) r.Add(i);
        }

   
        private void bNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpcijeSalter), trenutniUposlenik);
        }

        private void textBox_TextChanged(System.Object sender, TextChangedEventArgs e)
        {

        }

        private void listView_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Racun r1 = (Racun)listView.SelectedItem;
            nrvm.promijeniStanje(trenutni, r1);
            r.Clear();
            foreach (Racun i in trenutni.sviRacuni) r.Add(i);
        }
    }
}
