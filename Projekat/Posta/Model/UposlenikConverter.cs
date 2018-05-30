using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class UposlenikConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Uposlenik));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            if (jo["tipPosla"].Value<string>() == "Salterusa")
                return jo.ToObject<Salterusa>(serializer);

            if (jo["tipPosla"].Value<string>() == "Postar")
                return jo.ToObject<Postar>(serializer);

            if (jo["tipPosla"].Value<string>() == "Administrator")
                return jo.ToObject<Administrator>(serializer);

            return null;
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
