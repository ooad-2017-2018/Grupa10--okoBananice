using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class ePosta : IPosta
    {
        List<Uposlenik> sviUposlenici;
        List<Potrosac> sviPotrosaci;
        List<Paket> sviPaketi;
        List<Racun> sviRacuni;
        public ePosta()
        {
            sviUposlenici = new List<Uposlenik>();
            sviPotrosaci = new List<Potrosac>();
            sviPaketi = new List<Paket>();
            sviRacuni = new List<Racun>();
        }

        public Potrosac dajPotrosaca(string jmbg)
        {
            throw new NotImplementedException();
        }

        public void dodajPaket(Paket p)
        {
            throw new NotImplementedException();
        }

        public void dodajPotrosaca(Potrosac p)
        {
            throw new NotImplementedException();
        }

        public void dodajUposlenika(Uposlenik u)
        {
            throw new NotImplementedException();
        }
    }
}
