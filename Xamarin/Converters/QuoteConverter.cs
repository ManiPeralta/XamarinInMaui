using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Converters
{
    public class QuoteConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            //double value = e.NewValue;
            //rotatingLabel.Rotation = value;
            //sliderValue.Text = value.ToString();
            double fontSizeValue = (double)values[0];
            fontSizeValue.ToString(NumberFormatInfo.InvariantInfo);


            double fontColourValue = (double)values[1];
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
