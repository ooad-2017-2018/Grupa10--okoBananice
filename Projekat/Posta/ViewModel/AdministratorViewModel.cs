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
        #region Atributi
        private bool found;
        private Potrosac trazeni;
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
#endregion

        public AdministratorViewModel()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void obrisiPotrosaca()
        {
            string poruka = "";
            if (ePosta.Instanca.obrisiPotrosaca(Jmbg))
            {
                Found = false;
                Trazeni = null;
                poruka = "Potrosac uspjesno obrisan!";
            }
            else
            {
                poruka = "Potrosac nije obrisan (greska u sistemu)";
            }

            var dialog = new MessageDialog(poruka);
            dialog.ShowAsync();
        }

        public ICommand ObrisiPotrosacaCommand
        {
            get { return new CommandHandler(() => this.obrisiPotrosaca()); }
        }
        
        public async void pretraga()
        {
            try
            {
                Trazeni = null;
                Trazeni = await Task.Run(() => Baza.Instanca.dajPotrosaca(Jmbg));
                provjeri();
                if (Trazeni != null)
                {
                    Found = true;
                    var dialog = new MessageDialog("Uspjesno pronadjen potrosac!");
                    await dialog.ShowAsync();
                }
                else
                {
                    Found = false;
                    var dialog = new MessageDialog("Nije pronadjen potrosac.");
                    await dialog.ShowAsync();
                }
            }
            catch(Exception)
            {

            }
                
        }

        private void provjeri()
        {
            if(Trazeni == null)
            {
                Trazeni = ePosta.Instanca.dajPotrosaca(Jmbg);
            }
            if(ePosta.Instanca.obrisan(Trazeni)) Trazeni = null;
        }


    }
}
