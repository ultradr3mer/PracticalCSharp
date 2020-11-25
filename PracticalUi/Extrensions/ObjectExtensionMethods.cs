namespace PracticalUi.Extrensions
{
  /// <summary>
  /// The <see cref="ObjectExtensionMethods"/> class provides extension methods for the <see cref="object"/>.
  /// </summary>
  internal static class ObjectExtensionMethods
  {
    #region Methods

    public static T CopyPropertiesFrom<T>(this T self, object parent)
    {
      System.Reflection.PropertyInfo[] fromProperties = parent.GetType().GetProperties();
      System.Reflection.PropertyInfo[] toProperties = self.GetType().GetProperties();

      foreach (System.Reflection.PropertyInfo fromProperty in fromProperties)
      {
        foreach (System.Reflection.PropertyInfo toProperty in toProperties)
        {
          if (fromProperty.Name == toProperty.Name && fromProperty.PropertyType == toProperty.PropertyType)
          {
            toProperty.SetValue(self, fromProperty.GetValue(parent));
            break;
          }
        }
      }

      return self;
    }

    #endregion Methods
  }
}