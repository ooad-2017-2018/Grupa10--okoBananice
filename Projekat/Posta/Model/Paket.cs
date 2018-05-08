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
        private string grad, drzava;
        private double cijena, tezina;

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

        public int Id { get => id; set => id = value; }
        public Potrosac Posiljaoc { get => posiljaoc; set => posiljaoc = value; }
        public string Grad { get => grad; set => grad = value; }
        public string Drzava { get => drzava; set => drzava = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public double Tezina { get => tezina; set => tezina = value; }

        public double izracunajCijenu()
        {
            return cijena;
        }
    }
}
