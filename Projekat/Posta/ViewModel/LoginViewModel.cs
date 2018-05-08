using Posta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.ViewModel
{
    public class LoginViewModel
    {
        ePosta sveListe = ePosta.Instanca;

        private string eMail;
        private string pass;

        Potrosac potrosac;
        Uposlenik uposlenik;

        public string EMail
        {
            get
            {
                return eMail;
            }

            set
            {
                eMail = value;
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
