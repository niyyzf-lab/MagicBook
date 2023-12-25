using Avalonia.Data.Converters;

namespace MagicBook.Helper.Cover;

public class MessageNotification2Visibility:IValueConverter
{
    //编写转换器
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string str)
        {

            return !IsNullOrEmpty(str);
        }
        return false;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
