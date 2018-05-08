using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public abstract class Uposlenik
    {
        private string ime, prezime, email, password, adresa;
        private DateTime datumRodjenja;

        public Uposlenik()
        {

        }

        public Uposlenik(string ime, string prezime, string email, string password, string adresa, DateTime datumRodjenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.password = password;
            this.adresa = adresa;
            this.datumRodjenja = datumRodjenja;
        }

    }
}
