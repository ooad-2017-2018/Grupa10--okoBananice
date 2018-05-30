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

        /*
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
        */

        [ScaffoldColumn(false)]
        public string id { get; set; }
        [Required]
        public string ime { get; set; }
        [Required]
        public string prezime { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        public string adresa { get; set; }
        public DateTime datumRodjenja { get; set; }
        [Required]
        public string tipPosla { get; set; }

        public Uposlenik()
        {

        }

        public Uposlenik(string e, string p)
        {
            email = e;
            password = p;
        }
    }
}
