using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Geoban.WPF.HelloWorld.Converters
{
    public class HeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            byte heightLimit = byte.Parse(parameter.ToString());


            byte height = (byte)value;

            if (height > heightLimit)
            {
                return true;
            }
            else
                return false;


            // return height > 180;


            //throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
