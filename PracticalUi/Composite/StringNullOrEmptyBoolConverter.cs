using System;
using System.Globalization;
using System.Windows.Data;

namespace PracticalUi.Composite
{
  /// <summary>
  /// The <see cref="StringNullOrEmptyBoolConverter"/> class converts a string to a bool representing wheter it is empty or null.
  /// </summary>
  public class StringNullOrEmptyBoolConverter : IValueConverter
  {
    #region Methods

    /// <summary>Returns false if string is null or empty.</summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      string s = value as string;
      return !string.IsNullOrWhiteSpace(s);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion Methods
  }
}