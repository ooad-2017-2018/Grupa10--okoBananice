using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class Paket
    {
        private int id;
        private Potrosac posiljaoc;
        private string grad;
        private string drzava;
        private double cijena;
        private double tezina;

        public int Id
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
        public Potrosac Posiljaoc
        {
            get
            {
                return posiljaoc;
            }

            set
            {
                posiljaoc = value;
            }
        }
        public string Grad
        {
            get
            {
                return grad;
            }

            set
            {
                grad = value;
            }
        }
        public double Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            }
        }

        public string Drzava
        {
            get
            {
                return drzava;
            }

            set
            {
                drzava = value;
            }
        }

        public double Tezina
        {
            get
            {
                return tezina;
            }

            set
            {
                tezina = value;
            }
        }

        public Paket()
        {

        }

        public Paket(int id, Potrosac posiljaoc, string grad, string drzava, double cijena, double tezina)
        {
            this.Id = id;
            this.Posiljaoc = posiljaoc;
            this.Grad = grad;
            this.Drzava = drzava;
            this.Cijena = cijena;
            this.Tezina = tezina;
        }

       /* public int Id { get => id; set => id = value; }
        public Potrosac Posiljaoc { get => posiljaoc; set => posiljaoc = value; }
        public string Grad { get => grad; set => grad = value; }
        public string Drzava { get => drzava; set => drzava = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public double Tezina { get => tezina; set => tezina = value; }
            */
        public double izracunajCijenu()
        {
            return Cijena;
        }
    }
}
