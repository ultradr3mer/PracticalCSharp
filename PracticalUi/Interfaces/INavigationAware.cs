namespace PracticalUi.Interfaces
{
  /// <summary>
  /// The <see cref="INavigationAware"/> interface represents a data context that is aware of navigation.
  /// </summary>
  internal interface INavigationAware
  {
    #region Methods

    void OnNavigatingTo(object args);

    #endregion Methods
  }
}