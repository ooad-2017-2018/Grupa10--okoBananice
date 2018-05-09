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
    public sealed partial class PregledRacuna : Page, INotifyPropertyChanged
    {
        Potrosac trenutni;
        ObservableCollection<Racun> racuni;
        private PregledRacunaViewModel prvm;

        //probaj bez ovoga
        public ObservableCollection<Racun> Racuni
        {
            get
            {
                return racuni;
            }

            set
            {
                racuni = value;
                OnPropertyChanged("Racuni");
            }
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            trenutni = (Potrosac)e.Parameter;
            
            prvm.Trenutni = trenutni;
            prvm.Racuni = trenutni.SviRacuni;
        }

        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public PregledRacuna()
        {
            this.InitializeComponent();
            prvm = new PregledRacunaViewModel();
            this.DataContext = prvm;
        }

        private void bNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpcijePotrosaca), trenutni);
        }
        
    }
}
