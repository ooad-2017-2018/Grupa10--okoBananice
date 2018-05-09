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
    public class LoginViewModel : INotifyPropertyChanged
    {
        ePosta sveListe = ePosta.Instanca;
        
        private string eMail;
        private string pass;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public string EMail
        {
            get
            {
                return eMail;
            }

            set
            {
                eMail = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(EMail)));
                }
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

        public LoginViewModel()
        {
            eMail = "";
            pass = "";
        }

        
        public Potrosac validateP()
        {
            Potrosac novi = null;
            foreach(Potrosac p in sveListe.SviPotrosaci)
            {
                if(eMail.Equals(p.Email))
                {
                    if(pass.Equals(p.Password))
                    {
                        novi = p;
                        break;
                    }
                }
            }
            return novi;
        }

        public Uposlenik validateU()
        {
            Uposlenik novi = null;
            foreach (Uposlenik u in sveListe.SviUposlenici)
            {
                if (eMail.Equals(u.Email))
                {
                    if (pass.Equals(u.Password))
                    {
                        novi = u;
                        break;
                    }
                }
            }
            return novi;
        }
    }
}
