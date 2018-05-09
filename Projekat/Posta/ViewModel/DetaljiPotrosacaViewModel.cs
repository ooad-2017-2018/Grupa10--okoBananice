using Posta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.ViewModel
{
    public class DetaljiPotrosacaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public DetaljiPotrosacaViewModel() { }

        public void popuni()
        {
            if (trenutni != null)
            {
                Ime = trenutni.Ime;
                Prezime = trenutni.Prezime;
                Adresa = trenutni.Adresa;
                Email = trenutni.Email;
                Jmbg = trenutni.JMBG1;
                BrojTelefona = trenutni.BrojTelefona;
            }
        }

        #region atributi
        private string ime;
        private string prezime;
        private string adresa;
        private string email;
        private string jmbg;
        private string brojTelefona;
        private Potrosac trenutni;

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

        #endregion

    }
}
