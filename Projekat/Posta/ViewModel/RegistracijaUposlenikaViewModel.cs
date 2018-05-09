using Posta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Input;

namespace Posta.ViewModel
{
    public class RegistracijaUposlenikaViewModel : INotifyPropertyChanged
    {
        ePosta sveListe = ePosta.Instanca;
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private string imeU;
        private string prezimeU;
        private string JMBG;
        private string adresaU;
        private string emailU;
        private string pass;
        private DateTime datumRodjenja;
        private string pomocniJMBG;
        private string tipPosla;
        private bool radio;

        #region GetteriSetteri
        public string ImeU
        {
            get
            {
                return imeU;
            }

            set
            {
                imeU = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(ImeU)));
                }
            }
        }

        public string PrezimeU
        {
            get
            {
                return prezimeU;
            }

            set
            {
                prezimeU = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(PrezimeU)));
                }
            }
        }

        public string JMBG1
        {
            get
            {
                return JMBG;
            }

            set
            {
                JMBG = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(JMBG1)));
                }
            }
        }

        public string AdresaU
        {
            get
            {
                return adresaU;
            }

            set
            {
                adresaU = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(AdresaU)));
                }
            }
        }

        public string EmailU
        {
            get
            {
                return emailU;
            }

            set
            {
                emailU = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(EmailU)));
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

        public string PomocniJMBG
        {
            get
            {
                return pomocniJMBG;
            }

            set
            {
                pomocniJMBG = value;
            }
        }



        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Pass)));
                }
            }
        }

        public string TipPosla
        {
            get
            {
                return tipPosla;
            }

            set
            {
                tipPosla = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(TipPosla)));
                }
            }
        }

        #endregion

        public RegistracijaUposlenikaViewModel()
        {
            imeU = "";
            prezimeU = "";
            JMBG = "";
            adresaU = "";
            emailU = "";
            datumRodjenja = DateTime.Now;
            tipPosla = "";
            pass = "";
        }

        public bool validacijaJMBG()
        {
            //vraca true ako nije ispunjena validacija
            //vraca false ako jeste
            bool vracam = true;
            pomocniJMBG = datumRodjenja.Date.ToString();
            if (JMBG.Length != 13) return false;
            if (pomocniJMBG[0].Equals(JMBG[2]) && pomocniJMBG[1].Equals(JMBG[3]) && pomocniJMBG[3].Equals(JMBG[0]) && pomocniJMBG[4].Equals(JMBG[1]) && pomocniJMBG[7].Equals(JMBG[4]) && pomocniJMBG[8].Equals(JMBG[5]) && pomocniJMBG[9].Equals(JMBG[6]))
                return false;
            return vracam;
        }

        private void registrujUposlenika()
        {
            Uposlenik dodaj = null;
            if (radio)
            {
                dodaj = new Postar();
            }
            else dodaj = new Salterusa();
            dodaj.Ime = ImeU;
            dodaj.Prezime = PrezimeU;
            dodaj.Password = Pass;
            dodaj.Email = EmailU;
            dodaj.Adresa = AdresaU;
            ePosta.Instanca.dodajUposlenika(dodaj);
        }

        public ICommand RegistrujUposlenikaCommand
        {
            get { return new CommandHandler(() => this.registrujUposlenika()); }
        }

        public bool Radio
        {
            get
            {
                return radio;
            }

            set
            {
                radio = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Radio)));
                }
            }
        }
    }

}
