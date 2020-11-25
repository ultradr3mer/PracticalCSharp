using MahApps.Metro.Controls;
using PracticalUi.Interfaces;
using PracticalUi.ViewModels;
using PracticalUi.Views;
using Prism.Ioc;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PracticalUi
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App
  {
    #region Fields

    private static IContainerProvider containerInstance;
    private static MetroNavigationWindow navWin;

    #endregion Fields

    #region Methods

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
    }

    internal static void RequestNavigate<T>(object args) where T : Page
    {
      var content = containerInstance.Resolve<T>();
      (content.DataContext as INavigationAware)?.OnNavigatingTo(args);
      navWin.Navigate(content);
    }

    #endregion Methods
  }
}