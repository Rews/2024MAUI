using System.Globalization;

namespace _2024MAUI;

public class StringToColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if(value == null)
            return Colors.Red;
        
        string phoneNumber = value?.ToString().Trim().ToLower();
        if (phoneNumber.Length == 11)
            return Colors.Green;
        return Colors.Red;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}