using PracticalUi.ViewModels;
using Prism.Regions;
using System.Windows.Controls;

namespace PracticalUi.Views
{
  /// <summary>
  /// Interaction logic for LessonView.xaml
  /// </summary>
  public partial class LessonView : UserControl, INavigationAware
  {
    #region Constructors

    public LessonView()
    {
      InitializeComponent();

      this.DataContext = App.Resolve<LessonViewModel>();
      ((LessonViewModel)this.DataContext).Initialize();
    }

    #endregion Constructors

    #region Methods

    public bool IsNavigationTarget(NavigationContext navigationContext)
    {
      return true;
    }

    public void OnNavigatedFrom(NavigationContext navigationContext)
    {
    }

    public void OnNavigatedTo(NavigationContext navigationContext)
    {
    }

    #endregion Methods
  }
}