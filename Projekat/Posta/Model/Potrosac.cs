using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class Potrosac : IPotrosac
    {
        private string ime;
        private string prezime;
        private string brojTelefona;
        private string adresa;
        private string JMBG;
        private string email;
        private string password;
        private DateTime datumRodjenja;
        List<Racun> sviRacuni;
        List<Paket> sviPaketi;

        //pomocni konstruktor
        public Potrosac(string e, string p)
        {
            email = e;
            password = p;
            SviRacuni = new List<Racun>();
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string BrojTelefona
        {
            get
            {
                return brojTelefona;
            }

            set
            {
                brojTelefona = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
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
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
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
            }
        }

        public List<Racun> SviRacuni
        {
            get
            {
                return sviRacuni;
            }

            set
            {
                sviRacuni = value;
            }
        }

        public List<Paket> SviPaketi
        {
            get
            {
                return sviPaketi;
            }

            set
            {
                sviPaketi = value;
            }
        }

        public Potrosac()
        {
            SviRacuni = new List<Racun>();
            SviPaketi = new List<Paket>();
        }
        public Potrosac(string ime, string prezime, string brojTelefona, string adresa, string jMBG, string email, string password, DateTime datumRodjenja)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.BrojTelefona = brojTelefona;
            this.Adresa = adresa;
            JMBG1 = jMBG;
            this.Email = email;
            this.Password = password;
            this.DatumRodjenja = datumRodjenja;
            SviRacuni = new List<Racun>();
            SviPaketi = new List<Paket>();
        }

        public void DodajRacun(Racun r)
        {
            SviRacuni.Add(r);
        }

        public void SetujRacun(Racun r)
        {
            throw new NotImplementedException();
        }
    }
}
