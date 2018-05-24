using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public abstract class Uposlenik
    {
        [Key]
        private string id;
        private string ime;
        private string prezime;
        private string email;
        private string password;
        private string adresa;
        private DateTime datumRodjenja;
        private string tipPosla;

        protected Uposlenik()
        {

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

        public string TipPosla
        {
            get
            {
                return tipPosla;
            }

            set
            {
                tipPosla = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        //pomocni konstruktor
        public Uposlenik(string e, string p)
        {
            email = e;
            password = p;
        }
        public Uposlenik(string ime, string prezime, string email, string password, string adresa, DateTime datumRodjenja, string tipPosla)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Password = password;
            this.Adresa = adresa;
            this.DatumRodjenja = datumRodjenja;
            this.TipPosla = tipPosla; 
        }
        public Uposlenik(string ime, string prezime, string email, string password, string adresa, string tipPosla)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Password = password;
            this.Adresa = adresa;
            this.TipPosla = tipPosla;
        }
        public Uposlenik(string ime, string prezime, string email, string password, string adresa, DateTime datumRodjenja)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Password = password;
            this.Adresa = adresa;
            this.DatumRodjenja = datumRodjenja;
        }

    }
}
