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
            
        }
        

        private async void registrujUposlenika()
        {
            try
            {
                
                Uposlenik dodaj = null;
                if (Postar)
                {
                    dodaj = new Postar();
                    dodaj.tipPosla = "Postar";
                }
                else if (Salter)
                {
                    dodaj = new Salterusa();
                    dodaj.tipPosla = "Salterusa";
                }
                else
                {
                    throw new Exception("Morate oznaciti tip posla!");
                }
                dodaj.ime = ImeU;
                dodaj.prezime = PrezimeU;
                dodaj.password = Pass;
                dodaj.email = EmailU;
                dodaj.adresa = AdresaU;
                dodaj.datumRodjenja = DatumRodjenja;
                bool result = ePosta.Instanca.dodajUposlenika(dodaj);

                string poruka = "";

                if (result) poruka = "Uspjesno ste unijeli novog uposlenika!";
                else poruka = "Unos uposlenika nije uspio (greska u sistemu)";
                MessageDialog msgDialog = new MessageDialog(poruka);
                msgDialog.ShowAsync();
                
            }
            catch(Exception e)
            {
                var message = new MessageDialog(e.Message);
                message.ShowAsync();
            }
            
        }
        
        public ICommand RegistrujUposlenikaCommand
        {
            get { return new CommandHandler(() => this.registrujUposlenika()); }
        }
        
    }

}
