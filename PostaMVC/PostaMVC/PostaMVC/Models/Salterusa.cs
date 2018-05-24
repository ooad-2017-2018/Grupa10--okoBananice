using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class Salterusa : Uposlenik
    {
        public Salterusa() : base ()
        {

        }

        public Salterusa(string ime, string prezime, string email, string password, string adresa, DateTime datumRodjenja) : base(ime, prezime, email, password, adresa, datumRodjenja)
        {

        }

        public Salterusa(string e, string p) : base(e,p)
        {

        }

        /*public void DodajPotrosaca(Potrosac p)
        {

        }*/
    }
}
