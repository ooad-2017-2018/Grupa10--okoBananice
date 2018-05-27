using Posta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace Posta.ViewModel
{
    public class AdministratorViewModel : INotifyPropertyChanged
    {
        #region Atributi
        private bool found;
        private Potrosac trazeni;
        private string jmbg;

        public string Jmbg
        {
            get
            {
                return jmbg;
            }

            set
            {
                jmbg = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Jmbg)));
                }
            }
        }

        public ICommand PretraziPotrosacaCommand
        {
            get { return new CommandHandler(() => this.pretraga()); }
        }

        public Potrosac Trazeni
        {
            get
            {
                return trazeni;
            }

            set
            {
                trazeni = value;
            }
        }

        public bool Found
        {
            get
            {
                return found;
            }

            set
            {
                found = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Found)));
                }
            }
        }
#endregion

        public AdministratorViewModel()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        
  /*      private async void obrisiPotrosaca()
        {
            bool flag = await Task.Run(() => Baza.Instanca.obrisiPotrosaca(Jmbg));

            if (flag)
            {
                Found = false;
                Trazeni = null;
                var dialog1 = new MessageDialog("Uspjesno izbrisan!");
                dialog1.ShowAsync();
            }
            else
            {
                var dialog1 = new MessageDialog("Nije obrisan potrosac.");
                dialog1.ShowAsync();
            }

            //Baza.Instanca.obrisiPotrosaca("123456789");
            //Trazeni = ePosta.Instanca.dajPotrosaca(Jmbg);
            //ePosta.Instanca.obrisiPotrosaca(Trazeni);
            /*
            if (Trazeni != null)
            {
                Found = true;
             
                var dialog1 = new MessageDialog("Uspjesno izbrisan!");
                
                dialog1.ShowAsync();
            }
            else
            {
                Found = false;
                var dialog1 = new MessageDialog("Nije obrisan potrosac.");
                dialog1.ShowAsync();
            }*/
      //  }
    
       /* public ICommand ObrisiPotrosacaCommand
        {
            get { return new CommandHandler(() => this.obrisiPotrosaca()); }
        }*/
        
        public async void pretraga()
        {
            try
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

            }
                
        }




    }
}
