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

        #region Liste
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

        #endregion

        private ePosta()
        {
            SviUposlenici = new List<Uposlenik>();
            SviPotrosaci = new List<Potrosac>();
            SviPaketi = new List<Paket>();
            SviRacuni = new List<Racun>();
            //popuniPotrosace();
            //popuniUposlenike();

            Potrosac selma = new Model.Potrosac("Selma", "Vucijak", "062316446", "Logavina", "2307997175013", "selmav", "selma", DateTime.Today);
            selma.DodajRacun(new Model.Racun(1, 1, true));
            selma.DodajRacun(new Model.Racun(2, 2, false));
            dodajPotrosaca(selma);
            Potrosac faruk = new Model.Potrosac("F", "S", "365665", "Logavina", "12346789", "fsm", "etf", DateTime.Today);
            faruk.DodajRacun(new Model.Racun(1, 1, true));
            faruk.DodajRacun(new Model.Racun(2, 2, false));
            dodajPotrosaca(faruk);

            dodajUposlenika(new Salterusa("ilmas", "ilma"));
            dodajUposlenika(new Postar("faruks", "faruk"));
            dodajUposlenika(new Administrator());

        }

        private async void popuniUposlenike()
        {
            List<Uposlenik> test = await Task.Run(() => Baza.Instanca.dajSveUposlenike());
            if (test != null) SviUposlenici.AddRange(test);
        }

        private async void popuniPotrosace()
        {
           List<Potrosac> testP = await Task.Run(() => Baza.Instanca.dajSvePotrosace());
           if (testP != null) ePosta.Instanca.SviPotrosaci.AddRange(testP);
        }


        public Potrosac dajPotrosaca(string jmbg)
        {
            Potrosac p = null;
            try
            {
                p = SviPotrosaci.Find((Potrosac i) => i.JMBG.Equals(jmbg));
            }
            catch(Exception)
            {

            }
            return p;
        }

        public bool imaUposlenik(Uposlenik u)
        {
            foreach(Uposlenik i in SviUposlenici)
            {
                if (i.email.Equals(u.email)) return true;
            }
            return false;
        }


        public bool obrisan(Potrosac p)
        {
            foreach(Potrosac i in sviPotrosaci)
            {
                if (i.JMBG.Equals(p.JMBG)) return false;
            }
            return true;
        }

        public void dodajPaket(Paket p)
        {
            SviPaketi.Add(p);
        }

        public void dodajPotrosaca(Potrosac p)
        {
            SviPotrosaci.Add(p);
        }

        public bool dodajUposlenika(Uposlenik u)
        {
            if (imaUposlenik(u)) return false;
            else SviUposlenici.Add(u);
            return true;    
        }
        public bool obrisiPotrosaca(string jmbg)
        {
            Potrosac p = dajPotrosaca(jmbg);
            if (p != null)
            {
                sviPotrosaci.Remove(p);
                return true;
            }
            return false;
        }

        public Potrosac dajPotrosacaPoMailu(string email, string pass)
        {
            foreach(Potrosac p in sviPotrosaci)
            {
                if (p.email.Equals(email) && p.password.Equals(pass)) return p;
            }
            return null;
        }

        public Uposlenik dajUposlenikaPoMailu(string email, string pass)
        {
            foreach(Uposlenik u in sviUposlenici)
            {
                if (u.email.Equals(email) && u.password.Equals(pass)) return u;
            }
            return null;
        }

        public void promijeniRacun(Potrosac p, Racun r)
        {
            foreach(Potrosac i in SviPotrosaci)
            {
                if (i == p) i.sviRacuni.Find(k => k == r).PostaviPlacen();
            }
        }
    }
}
