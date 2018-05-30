using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Web.Http;

namespace Posta.Model
{
    
    public class Baza
    {
        #region Pattern
        public static Baza bazaInstanca;
        public static Baza Instanca
        {
            get
            {
                return bazaInstanca ?? (bazaInstanca = new Baza());
            }
        }
        private Baza()
        {

        }
        #endregion

        List<Potrosaci> items = new List<Potrosaci>();
        IMobileServiceTable<Potrosaci> tabelaPotrosaci = App.MobileService.GetTable<Potrosaci>();
        IMobileServiceTable<Uposlenici> tabelaUposlenici = App.MobileService.GetTable<Uposlenici>();
        
        public async Task<List<Uposlenik>> dajSveUposlenike()
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

            string url = "http://localhost:50180/Uposleniks/GetSve";
            Uri requestUri = new Uri(url);
            Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();
            
            string httpResponseBody = "";
            try
            {
                httpResponse = await httpClient.GetAsync(requestUri);

                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();

                string json = httpResponseBody;
                
                JsonConverter[] converters = { new UposlenikConverter() };
                var test = JsonConvert.DeserializeObject<List<Uposlenik>>(json, new JsonSerializerSettings() { Converters = converters });

                return test;
            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;

            }
            return null;
        }

        public async Task<List<Potrosac>> dajSvePotrosace()
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

            string url = "http://localhost:50180/Potrosacs/GetSve";
            Uri requestUri = new Uri(url);
            Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();

            
            string httpResponseBody = "";
            try
            {
                httpResponse = await httpClient.GetAsync(requestUri);

                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();

                string json = httpResponseBody;

                var test = JsonConvert.DeserializeObject<List<Potrosac>>(json);
                return test;
            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;

            }
            return null;
        }

        public async Task<bool> dodajPotrosaca(Potrosac p)
        {
            /*
            var values = new Dictionary<string, string>
            {
                { "Ime", p.ime },
                { "Prezime", p.prezime },
                {"Email", p.email },
                {"Password", p.password },
                {"BrojTelefona", p.brojTelefona },
                {"Adresa", p.adresa },
                {"JMBG", p.JMBG },
                {"DatumRodjenja", p.datumRodjenja.ToString() },
            };

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            
            var response = await client.PostAsync("http://localhost:50180/Potrosacs/Create", content);*/

            /*var content = new FormUrlEncodedContent(values);

var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);

var responseString = await response.Content.ReadAsStringAsync();*/
            
            /*
            try
            {
                Potrosaci obj = new Potrosaci();
                obj.Ime = p.Ime;
                obj.Prezime = p.Prezime;
                obj.Adresa = p.Adresa;
                obj.Email = p.Email;
                obj.Jmbg = p.JMBG1;
                obj.BrojTelefona = p.BrojTelefona;
                await Task.Run(() => tabelaPotrosaci.InsertAsync(obj));

            }
            catch (Exception ex)
            {
                throw ex;
                //MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                //msgDialogError.ShowAsync();
            }*/
            return true;
        }
        public async Task<bool> dodajUposlenka(Uposlenik p)
        {/*
            try
            {
                Uposlenici obj = new Uposlenici();
                obj.Ime = p.Ime;
                obj.Prezime = p.Prezime;
                obj.Adresa = p.Adresa;
                obj.Email = p.Email;
                obj.Password = p.Password;
                obj.DatumRodjenja = p.DatumRodjenja.ToString();
                obj.TipPosla = p.TipPosla;
                await Task.Run(() => tabelaUposlenici.InsertAsync(obj));
            }
            catch (Exception ex)
            {
                throw ex;
                
            }*/
            return true;
        }

        public async Task<Potrosac> dajPotrosaca(string jmbg)
       
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

            string url = "http://localhost:50180/Potrosacs/GetJMBG?JMBG=" + jmbg;
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

                return novi;

            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;

            }
            return null;
        
        /*try
        {
            Trazeni = null;
            Trazeni = await Task.Run(() => Baza.Instanca.dajPotrosaca(Jmbg));

            if (Trazeni != null)
            {
                Found = true;
                var dialog = new MessageDialog("Uspjesno pronadjen potrosac!");
                await dialog.ShowAsync();
            }
            else
            {
                Found = false;
                var dialog = new MessageDialog("Nije pronadjen potrosac.");
                await dialog.ShowAsync();
            }
        }
        catch(Exception)
        {

        }*/

    }
        /*
            items = new List<Potrosaci>();
            items.AddRange(await tabelaPotrosaci.Where(i => i.Jmbg == jmbg).ToListAsync());

            Potrosac novi = new Potrosac();
            try
            {
                novi.Ime = items[0].Ime;
                novi.Prezime = items[0].Prezime;
                novi.Adresa = items[0].Adresa;
                novi.JMBG1 = items[0].Jmbg;
                novi.Email = items[0].Email;
                novi.BrojTelefona = items[0].BrojTelefona;
                return novi;
            }
            catch(Exception)
            {
                
            }*/
           
        }
        
        
       /* public async Task<bool> obrisiPotrosaca(string jmbg)
        {
        
            try
            {
                List<Potrosaci> temp = new List<Potrosaci>();
                temp.AddRange(await tabelaPotrosaci.Where(i => i.Jmbg == jmbg).ToListAsync());
                
                await Task.Run(() => tabelaPotrosaci.DeleteAsync(temp[0]));
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        return false;
        } */
        
    }
