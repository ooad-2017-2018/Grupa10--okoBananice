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
    public class RegistracijaUposlenikaViewModel : INotifyPropertyChanged
    {
        
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
        private bool postar;
        private bool salter;
        private bool bRegistracija;

        #region GetteriSetteri

        public bool BRegistracija
        {
            get
            {
                return bRegistracija;
            }

            set
            {
                bRegistracija = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(BRegistracija)));
                }
            }
        }

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


        public bool Salter
        {
            get
            {
                return salter;
            }

            set
            {
                salter = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Salter)));
                }
            }
        }

        public bool Postar
        {
            get
            {
                return postar;
            }

            set
            {
                postar = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Postar)));
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
            BRegistracija = true;
        }
        

        private async void registrujUposlenika()
        {
            try
            {
                BRegistracija = false;
                Uposlenik dodaj = null;
                if (Postar)
                {
                    dodaj = new Postar();
                    dodaj.TipPosla = "Postar";
                }
                else if (Salter)
                {
                    dodaj = new Salterusa();
                    dodaj.TipPosla = "Salterusa";
                }
                else
                {
                    throw new Exception("Morate oznaciti tip posla!");
                }
                dodaj.Ime = ImeU;
                dodaj.Prezime = PrezimeU;
                dodaj.Password = Pass;
                dodaj.Email = EmailU;
                dodaj.Adresa = AdresaU;
                dodaj.DatumRodjenja = DatumRodjenja;
                //ePosta.Instanca.dodajUposlenika(dodaj);
                
                bool result = await Task.Run(() => Baza.Instanca.dodajUposlenka(dodaj));
                if (result)
                {
                    MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog uposlenika.");
                    msgDialog.ShowAsync();
                }
            }
            catch(Exception e)
            {
                var message = new MessageDialog(e.Message);
                message.ShowAsync();
            }
            BRegistracija = true;
        }
        
        public ICommand RegistrujUposlenikaCommand
        {
            get { return new CommandHandler(() => this.registrujUposlenika()); }
        }
        
    }

}
