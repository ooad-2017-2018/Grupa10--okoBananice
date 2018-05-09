using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.ViewModel
{
    public class ShopViewModel : INotifyPropertyChanged
    {
        #region radioButtonsAtributi
        private bool R1;
        private bool R2;
        private bool R3;
        private bool R4;
        private bool R5;
        private bool R6;
        private bool R7;
        private bool R8;
        private bool R9;

        private bool M1;
        private bool M2;
        private bool M3;
        private bool M4;
        private bool M5;
        private bool M6;
        private bool M7;
        private bool M8;
        private bool M9;
        #endregion
        #region razgledniceProperty
        public bool R11
        {
            get
            {
                return R1;
            }

            set
            {
                R1 = value;
                OnPropertyChanged("R11");
            }
        }

        public bool R21
        {
            get
            {
                return R2;
            }

            set
            {
                R2 = value;
                OnPropertyChanged("R21");
            }
        }

        public bool R31
        {
            get
            {
                return R3;
            }

            set
            {
                R3 = value;
                OnPropertyChanged("R31");
            }
        }

        public bool R41
        {
            get
            {
                return R4;
            }

            set
            {
                R4 = value;
                OnPropertyChanged("R41");
            }
        }

        public bool R51
        {
            get
            {
                return R5;
            }

            set
            {
                R5 = value;
                OnPropertyChanged("R51");
            }
        }

        public bool R61
        {
            get
            {
                return R6;
            }

            set
            {
                R6 = value;
                OnPropertyChanged("R61");
            }
        }

        public bool R71
        {
            get
            {
                return R7;
            }

            set
            {
                R7 = value;
                OnPropertyChanged("R71");
            }
        }

        public bool R81
        {
            get
            {
                return R8;
            }

            set
            {
                R8 = value;
                OnPropertyChanged("R81");
            }
        }

        public bool R91
        {
            get
            {
                return R9;
            }

            set
            {
                R9 = value;
                //OnPropertyChanged("R91");
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(R91)));
                }
            }
        }
        #endregion
        #region markiceProperty
        public bool M11
        {
            get
            {
                return M1;
            }

            set
            {
                M1 = value;
                OnPropertyChanged("M11");
            }
        }

        public bool M21
        {
            get
            {
                return M2;
            }

            set
            {
                M2 = value;
                OnPropertyChanged("M21");
            }
        }

        public bool M31
        {
            get
            {
                return M3;
            }

            set
            {
                M3 = value;
                OnPropertyChanged("M31");
            }
        }

        public bool M41
        {
            get
            {
                return M4;
            }

            set
            {
                M4 = value;
                OnPropertyChanged("M41");
            }
        }

        public bool M51
        {
            get
            {
                return M5;
            }

            set
            {
                M5 = value;
                OnPropertyChanged("M51");
            }
        }

        public bool M61
        {
            get
            {
                return M6;
            }

            set
            {
                M6 = value;
                OnPropertyChanged("M61");
            }
        }

        public bool M71
        {
            get
            {
                return M7;
            }

            set
            {
                M7 = value;
                OnPropertyChanged("M71");
            }
        }

        public bool M81
        {
            get
            {
                return M8;
            }

            set
            {
                M8 = value;
                OnPropertyChanged("M81");
            }
        }

        public bool M91
        {
            get
            {
                return M9;
            }

            set
            {
                M9 = value;
                OnPropertyChanged("M91");
            }
        }
        #endregion
        

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ShopViewModel()
        {
            R91 = true;
        }


    }
}
