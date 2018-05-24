using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.Model
{
    public class Racun 
    {
        private int id;
        private int cijena;
        private bool stanje;

        //public event PropertyChangedEventHandler PropertyChanged;
        /*protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }*/

        /*public override string ToString()
        {
            string povratni = "ID: " + id.ToString() + " Cijena: " + cijena.ToString() + " Stanje: ";
            if (stanje) povratni += " Placeno";
            else povratni += "Nije placeno";
            return povratni;
        }*/

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
          //      OnPropertyChanged("Id");
            }
        }

        public int Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            //    OnPropertyChanged("Cijena");
            }
        }

        public bool Stanje
        {
            get
            {
                return stanje;
            }

            set
            {
                stanje = value;
              //  OnPropertyChanged("Stanje");
            }
        }

        public Racun()
        {

        }

        public Racun(int id, int cijena, bool stanje)
        {
            this.Id = id;
            this.Cijena = cijena;
            this.Stanje = stanje;
        }

        /*public void GenerisiID()
        {
            throw new NotImplementedException();
        }

        public void PostaviPlacen()
        {
            throw new NotImplementedException();
        }*/
    }
}
