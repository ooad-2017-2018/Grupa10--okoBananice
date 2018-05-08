using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class Postar : Uposlenik
    {
        public Postar(string ime, string prezime, string email,string password, string adresa, DateTime datumRodjenja) : base(ime, prezime, email, password, adresa, datumRodjenja) 
        {

        }

    public void PregledPaketa(Paket p)
        {
            
        }
    }
}
