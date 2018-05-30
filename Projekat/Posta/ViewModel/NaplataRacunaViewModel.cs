using Posta.Forms;
using Posta.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace Posta.ViewModel
{
    public class NaplataRacunaViewModel
    {
        public NaplataRacunaViewModel() { }

        public void promijeniStanje(Potrosac p, Racun r)
        {
            ePosta.Instanca.promijeniRacun(p, r);
        }

    }
}
