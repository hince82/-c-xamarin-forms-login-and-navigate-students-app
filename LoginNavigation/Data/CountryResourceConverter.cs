using System;
using Xamarin.Forms;

namespace LoginNavigation.Data
{
    public class CountryResourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ImageSource.FromResource("LoginNavigation.Images.Country." + (value ?? ""));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}