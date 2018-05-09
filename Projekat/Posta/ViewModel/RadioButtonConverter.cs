using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Posta.ViewModel
{
    public class RadioButtonConverter : IValueConverter
    {
        public object Convert(object v, Type t, object p, string l)
        {
            return v.Equals(p);
        }
        public object ConvertBack(object v, Type t, object p, string l)
        {
            return System.Convert.ToBoolean(v) ? p : null;
        }
    }
}
