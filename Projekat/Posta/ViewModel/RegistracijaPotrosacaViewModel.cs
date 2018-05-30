using Posta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace Posta.ViewModel
{
    public class RegistracijaPotrosacaViewModel : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public RegistracijaPotrosacaViewModel()
        {
            ime = prezime = jmbg = brojTelefona = adresa = email = password = "";
        }
        #region Atributi_Properties
        private string ime;
        private string prezime;
        private DateTime datumRodjenja;
        private string jmbg;
        private string brojTelefona;
        private string adresa;
        private string email;
        private string password;
        
        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Ime)));
                }
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Prezime)));
                }
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(DatumRodjenja)));
                }
            }
        }

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

        public string BrojTelefona
        {
            get
            {
                return brojTelefona;
            }

            set
            {
                brojTelefona = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(BrojTelefona)));
                }
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Adresa)));
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
                }
            }
        }
        #endregion

        public ICommand RegistrujPotrosacaCommand
        {
            get { return new CommandHandler(() => this.registrujPotrosaca()); }
        }

        private void registrujPotrosaca()
        {
            try
            {
                Potrosac novi = new Potrosac(Ime, Prezime, BrojTelefona, Adresa, Jmbg, Email, Password, DatumRodjenja);
                ePosta.Instanca.dodajPotrosaca(novi);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog potrosaca.");
                msgDialog.ShowAsync();
                
            }
            catch(Exception ex)
            {
                var msg = new MessageDialog(ex.Message);
                msg.ShowAsync();
            }
            
        }
    }
}
