using PracticalUi.Views;
using Prism.Ioc;
using System.Windows;

namespace PracticalUi
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App
  {
    #region Fields

    private static IContainerProvider containerInstance;

    #endregion Fields

    #region Methods

    internal static object Resolve<T>()
    {
      return containerInstance.Resolve<T>();
    }

    protected override Window CreateShell()
    {
      containerInstance = this.Container;

      return Container.Resolve<MainWindow>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {

    }

    #endregion Methods
  }
}