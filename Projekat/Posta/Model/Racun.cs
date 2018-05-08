using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class Racun : IRacun
    {
        private int id,cijena;
        private bool stanje;


        public Racun()
        {

        }

        public Racun(int id, int cijena, bool stanje)
        {
            this.Id = id;
            this.Cijena = cijena;
            this.Stanje = stanje;
        }

        public int Id { get => id; set => id = value; }
        public int Cijena { get => cijena; set => cijena = value; }
        public bool Stanje { get => stanje; set => stanje = value; }

        public void GenerisiID()
        {
            throw new NotImplementedException();
        }

        public void PostaviPlacen()
        {
            throw new NotImplementedException();
        }
    }
}
