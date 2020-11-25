using System;
using System.Globalization;
using System.Windows.Data;

namespace PracticalUi.Composite
{
  /// <summary>
  /// The <see cref="ObjectNullBoolConverter"/> class converts an object to a bool representing wheter it is null.
  /// </summary>
  public class ObjectNullBoolConverter : IValueConverter
  {
    #region Methods

    /// <summary>Returns false if object is null.</summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value != null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion Methods
  }
}