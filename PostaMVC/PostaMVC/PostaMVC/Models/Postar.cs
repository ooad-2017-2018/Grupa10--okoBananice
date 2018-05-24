using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class Postar : Uposlenik
    {
        public Postar() : base()
        {

        }

        public Postar(string ime, string prezime, string email,string password, string adresa, DateTime datumRodjenja) : base(ime, prezime, email, password, adresa, datumRodjenja) 
        {

        }


        public Postar(string e, string p) : base(e,p)
        {

        }

/*        public void PregledPaketa(Paket p)
        {
            
        }*/
    }
}
