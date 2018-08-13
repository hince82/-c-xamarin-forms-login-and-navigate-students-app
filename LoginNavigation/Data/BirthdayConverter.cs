using System;
using Xamarin.Forms;

namespace LoginNavigation.Data
{
    public class BirthdayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime bday = (DateTime)value;
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            return age;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}