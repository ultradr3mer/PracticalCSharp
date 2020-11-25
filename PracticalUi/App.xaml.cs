using MahApps.Metro.Controls;
using PracticalUi.Interfaces;
using PracticalUi.Services;
using PracticalUi.ViewModels;
using PracticalUi.Views;
using Prism.Ioc;
using System.Windows;
using System.Windows.Controls;

namespace PracticalUi
{
  /// <summary>
  /// The <see cref="App"/> class is the main entry point.
  /// </summary>
  public partial class App
  {
    #region Fields

    private static IContainerProvider containerInstance;
    private static MetroNavigationWindow navWin;

    #endregion Fields

    #region Methods

    internal static void Navigate<T>(object args) where T : Page
    {
      T content = containerInstance.Resolve<T>();
      (content.DataContext as INavigationAware)?.OnNavigatingTo(args);
      navWin.Navigate(content);
    }

    internal static object Resolve<T>()
    {
      return containerInstance.Resolve<T>();
    }

    protected override Window CreateShell()
    {
      containerInstance = this.Container;

      navWin = new MetroNavigationWindow();
      navWin.Navigate(new LessonsOverviewView());
      return navWin;
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.RegisterSingleton<LessonViewModel>();
      containerRegistry.RegisterSingleton<ScriptingService>();
    }

    #endregion Methods
  }
}