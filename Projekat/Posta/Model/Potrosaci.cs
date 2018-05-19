using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    class Potrosaci
    {
        public string id { get; set; }
        [JsonProperty(PropertyName = "Ime")]
        public string Ime { get; set; }
        [JsonProperty(PropertyName = "Prezime")]
        public string Prezime { get; set; }
        [JsonProperty(PropertyName = "Adresa")]
        public string Adresa { get; set; }
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "Jmbg")]
        public string Jmbg { get; set; }
        [JsonProperty(PropertyName = "BrojTelefona")]
        public string BrojTelefona { get; set; }
    }
}
