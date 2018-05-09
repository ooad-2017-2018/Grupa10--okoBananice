using Posta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace Posta.ViewModel
{
    public class AdministratorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private bool found;

        private Potrosac trazeni;
        public AdministratorViewModel()
        {

        }

        private string jmbg;

        public string Jmbg
        {
            get
            {
                return jmbg;
            }

            set
            {
                jmbg = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Jmbg)));
                }
            }
        }

        public ICommand PretraziPotrosacaCommand
        {
            get { return new CommandHandler(() => this.pretraga()); }
        }

        public Potrosac Trazeni
        {
            get
            {
                return trazeni;
            }

            set
            {
                trazeni = value;
            }
        }

        public bool Found
        {
            get
            {
                return found;
            }

            set
            {
                found = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Found)));
                }
            }
        }

        public void pretraga()
        {
            Trazeni = ePosta.Instanca.dajPotrosaca(Jmbg);
            if (Trazeni != null)
            {
                Found = true;
                var dialog = new MessageDialog("Uspjesno pronadjen potrosac!");
                dialog.ShowAsync();
            }
            else
            {
                Found = false;
                var dialog = new MessageDialog("Nije pronadjen potrosac.");
                dialog.ShowAsync();
            }
        }



    }
}
