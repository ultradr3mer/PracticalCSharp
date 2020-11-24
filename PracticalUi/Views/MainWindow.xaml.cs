using MahApps.Metro.Controls;
using Prism.Regions;
using System.Windows;
using Unity;

namespace PracticalUi.Views
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : MetroWindow
  {
    public MainWindow(RegionManager regionManager, IUnityContainer container)
    {
      InitializeComponent();

      //regionManager.RegisterViewWithRegion("MainRegion", () => container.Resolve<LessonsOverviewView>());
      regionManager.RegisterViewWithRegion("MainRegion", () => container.Resolve<LessonView>());
    }
  }
}
