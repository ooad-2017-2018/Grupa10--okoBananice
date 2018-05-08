using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Posta.ViewModel;
using System.ComponentModel;
using Posta.Model;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Posta.Forms
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LogIn : Page, INotifyPropertyChanged
    {
        public LoginViewModel lvm { get; set; } = new LoginViewModel();

        public LogIn()
        {
            this.InitializeComponent();
            //hardkodirani
            ePosta.Instanca.dodajPotrosaca(new Potrosac("selmav", "selma"));
            ePosta.Instanca.dodajUposlenika(new Salterusa("ilmas", "ilma"));
            ePosta.Instanca.dodajUposlenika(new Postar("faruks", "faruk"));
            ePosta.Instanca.dodajUposlenika(new Administrator());
            
            this.DataContext = lvm;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void bLogin_Click(object sender, RoutedEventArgs e)
        {
            var osobaP = lvm.validateP();
            var osobaU = lvm.validateU();
            if(osobaP != null)
            {
                //ulogovao potrosac
                porukaGreske.Visibility = Visibility.Collapsed;
                GlavniFrame.Navigate(typeof(OpcijePotrosaca), this.DataContext);
            }
            else
            {
                if(osobaU != null)
                {
                    porukaGreske.Visibility = Visibility.Collapsed;
                    //ulogovao uposlenik
                    if (osobaU is Salterusa)
                        GlavniFrame.Navigate(typeof(OpcijeSalter), this.DataContext);
                    else if (osobaU is Postar)
                        GlavniFrame.Navigate(typeof(FormaPostara), this.DataContext);
                    else if (osobaU is Administrator)
                        GlavniFrame.Navigate(typeof(AdministratorOpcije), this.DataContext);
                }
                else
                {
                    porukaGreske.Visibility = Visibility.Visible;
                }
            }
        }

        private void tbEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbEmail.Text.Equals("E-mail"))
                tbEmail.Text = "";
        }
        

    }
}
