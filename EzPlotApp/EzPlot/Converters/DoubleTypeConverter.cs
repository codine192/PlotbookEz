using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xaml;

namespace EzPlot.Converters
{
    public class DoubleTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            return base.CanConvertFrom(context, sourceType);
            
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)

        {
            if (value is string stringValue)
            {
                return double.Parse(stringValue);
            }
            return base.ConvertFrom(context, culture, value);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is double doubleValue)
            {
                return value.ToString();
            }
            return base.ConvertTo(context, culture, value, destinationType);

        }

    }
}
