using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Posta.Model
{
    public class Baza
    {
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

        IMobileServiceTable<Potrosaci> userTableObj = App.MobileService.GetTable<Potrosaci>();
        IMobileServiceTable<Uposlenici> userTableObjUposlenici = App.MobileService.GetTable<Uposlenici>();
        public void dodajPotrosaca(Potrosac p)
        {
            try
            {
                Potrosaci obj = new Potrosaci();
                obj.Ime = p.Ime;
                obj.Prezime = p.Prezime;
                obj.Adresa = p.Adresa;
                obj.Email = p.Email;
                obj.Jmbg = p.JMBG1;
                obj.BrojTelefona = p.BrojTelefona;
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog potrosaca.");
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }
        public void dodajUposlenka(Uposlenik p)
        {
            try
            {
                Uposlenici obj = new Uposlenici();
                obj.Ime = p.Ime;
                obj.Prezime = p.Prezime;
                obj.Adresa = p.Adresa;
                obj.Email = p.Email;
                obj.Password = p.Password;
                obj.TipPosla = p.TipPosla;
                userTableObjUposlenici.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog uposlenika.");
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }
    }
}
