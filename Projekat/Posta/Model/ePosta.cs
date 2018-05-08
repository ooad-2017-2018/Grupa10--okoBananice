using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class ePosta : IPosta
    {
        public static ePosta ePostaInstanca;
        private List<Uposlenik> sviUposlenici;
        private List<Potrosac> sviPotrosaci;
        private List<Paket> sviPaketi;
        private List<Racun> sviRacuni;

        public static ePosta Instanca
        {
            get
            {
                return ePostaInstanca ?? (ePostaInstanca = new ePosta());
            }
        }
        
        public List<Uposlenik> SviUposlenici
        {
            get
            {
                return sviUposlenici;
            }

            set
            {
                sviUposlenici = value;
            }
        }

        public List<Potrosac> SviPotrosaci
        {
            get
            {
                return sviPotrosaci;
            }

            set
            {
                sviPotrosaci = value;
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

        private ePosta()
        {
            SviUposlenici = new List<Uposlenik>();
            SviPotrosaci = new List<Potrosac>();
            SviPaketi = new List<Paket>();
            SviRacuni = new List<Racun>();
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
            sviPotrosaci.Add(p);
        }

        public void dodajUposlenika(Uposlenik u)
        {
            SviUposlenici.Add(u);
        }
    }
}
