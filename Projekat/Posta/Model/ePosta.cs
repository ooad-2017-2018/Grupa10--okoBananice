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
            Potrosac p = null;
            try
            {
                p = sviPotrosaci.Find((Potrosac i) => i.JMBG1.Equals(jmbg));
            }
            catch(Exception)
            {

            }
            return p;
        }

        public void dodajPaket(Paket p)
        {
            SviPaketi.Add(p);
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
