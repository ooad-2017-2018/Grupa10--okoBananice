using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class Potrosac : IPotrosac
    {
        private string ime, prezime, brojTelefona, adresa, JMBG, email, password;
        private DateTime datumRodjenja;
        List<Racun> sviRacuni;
        List<Paket> sviPaketi;

        public Potrosac()
        {
            sviRacuni = new List<Racun>();
            sviPaketi = new List<Paket>();
        }
        public Potrosac(string ime, string prezime, string brojTelefona, string adresa, string jMBG, string email, string password, DateTime datumRodjenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojTelefona = brojTelefona;
            this.adresa = adresa;
            JMBG = jMBG;
            this.email = email;
            this.password = password;
            this.datumRodjenja = datumRodjenja;
            sviRacuni = new List<Racun>();
            sviPaketi = new List<Paket>();
        }

        public void DodajRacun(Racun r)
        {
            throw new NotImplementedException();
        }

        public void SetujRacun(Racun r)
        {
            throw new NotImplementedException();
        }
    }
}
