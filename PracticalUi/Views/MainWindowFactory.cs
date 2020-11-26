using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using PracticalUi.Interfaces;
using System.Threading.Tasks;
using Unity;

namespace PracticalUi.Views
{
  public class MainWindowFactory : IMessageDisplay
  {
    #region Fields

    private MetroNavigationWindow window;

    #endregion Fields

    #region Constructors

    public MainWindowFactory(IUnityContainer container)
    {
      container.RegisterInstance<IMessageDisplay>(this);
    }

    #endregion Constructors

    #region Methods

    public MetroNavigationWindow Create()
    {
      this.window = new MetroNavigationWindow
      {
        Title = "Practical C#",
        Width = 1280,
        Height = 720
      };
      return this.window;
    }

    public async Task ShowMessageAsync(string title, string message)
    {
      await this.window.ShowMessageAsync(title, message);
    }

    #endregion Methods
  }
}