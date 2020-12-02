using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace PracticalUi.Composite
{
  /// <summary>
  /// The <see cref="StringNullOrEmptyVisibilityConverter"/> class converts a string to a visibility representing wheter it is empty or null.
  /// </summary>
  public class StringNullOrEmptyVisibilityConverter : IValueConverter
  {
    #region Methods

    /// <summary>Returns collapsed if string is null or empty.</summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      string s = value as string;
      return string.IsNullOrWhiteSpace(s) ? Visibility.Collapsed : Visibility.Visible;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion Methods
  }
}