using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Views.Converters
{
    public class ObjectToBooleanConverter : OneWayConverter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) { return false; }

            if (value.GetType().IsValueType)
            {
                return value == Activator.CreateInstance(value.GetType());
            }
            else if (value is string)
            {
                return !string.IsNullOrEmpty((string)value);
            }

            return true;
        }
    }
}
