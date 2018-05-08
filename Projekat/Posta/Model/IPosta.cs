using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    interface IPosta
    {
        void dodajPaket(Paket p);
        Potrosac dajPotrosaca(string jmbg);
        void dodajPotrosaca(Potrosac p);
        void dodajUposlenika(Uposlenik u);
    }
}
