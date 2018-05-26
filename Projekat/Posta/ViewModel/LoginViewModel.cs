using Newtonsoft.Json;
using Posta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Posta.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        ePosta sveListe = ePosta.Instanca;
        
        private string eMail;
        private string pass;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public string EMail
        {
            get
            {
                return eMail;
            }

            set
            {
                eMail = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(EMail)));
                }
            }
        }
        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Pass)));
                }
            }
        }

        public LoginViewModel()
        {
            eMail = "";
            pass = "";
        }

        
        public async Task<Potrosac> validateP()
        {
            Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();

            var headers = httpClient.DefaultRequestHeaders;

            string header = "ie";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }

            header = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.181 Safari/537.36";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }

            string url = "http://localhost:50180/Potrosacs/GetAccount?Email=" + EMail + "&password=" + Pass;
            //Uri requestUri = new Uri("http://localhost:50180/Potrosacs/GetAccount?Email" + EMail + "&password=" + Pass);
            Uri requestUri = new Uri(url);
            Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();

            Potrosac novi = null;

            string httpResponseBody = "";
            try
            {
                httpResponse = await httpClient.GetAsync(requestUri);

                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();

                string json = httpResponseBody;
                novi = JsonConvert.DeserializeObject<Potrosac>(json);
                
            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;

            }
            return novi;
        }

        public async Task<Uposlenik> validateU()
        {
            Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();

            var headers = httpClient.DefaultRequestHeaders;

            string header = "ie";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }

            header = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.181 Safari/537.36";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }

            string url = "http://localhost:50180/Uposleniks/GetAccount?Email=" + EMail + "&Password=" + Pass;
            //Uri requestUri = new Uri("http://localhost:50180/Potrosacs/GetAccount?Email" + EMail + "&password=" + Pass);
            Uri requestUri = new Uri(url);
            Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();

            Uposlenik novi = null;

            string httpResponseBody = "";
            try
            {
                httpResponse = await httpClient.GetAsync(requestUri);

                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();

                string json = httpResponseBody;
                //novi = JsonConvert.DeserializeObject<Uposlenik>(json);
                if(json.Contains("Salterusa")) novi = JsonConvert.DeserializeObject<Salterusa>(json);
                else if(json.Contains("Postar")) novi = JsonConvert.DeserializeObject<Postar>(json);
                return novi;

            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;

            }
            return null;
        }
    }
}
