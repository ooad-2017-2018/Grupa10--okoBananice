using Posta.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Posta.ViewModel
{
    public class PregledRacunaViewModel : INotifyPropertyChanged
    {
        private Potrosac trenutni;
        private ObservableCollection<Racun> racuni;

        public Potrosac Trenutni
        {
            get
            {
                return trenutni;
            }

            set
            {
                trenutni = value;
            }
        }

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

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public PregledRacunaViewModel()
        {

        }
    }
}
