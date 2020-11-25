using MahApps.Metro.Controls;

namespace PracticalUi.Views
{
  public class MainWindowFactory
  {
    #region Methods

    public MetroNavigationWindow Create()
    {
      var window = new MetroNavigationWindow();
      window.Title = "Practical C#";
      window.Width = 1280;
      window.Height = 720;
      return window;
    }

    #endregion Methods
  }
}