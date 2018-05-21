using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    class Uposlenici
    {
        public string id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Adresa { get; set; }
        public string DatumRodjenja { get; set; }
        public string TipPosla { get; set; }
    }
}
