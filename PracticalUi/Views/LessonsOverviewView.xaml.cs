using PracticalUi.ViewModels;
using Prism.Regions;
using System.Windows.Controls;

namespace PracticalUi.Views
{
  /// <summary>
  /// Interaction logic for LessonsOverview.xaml
  /// </summary>
  public partial class LessonsOverviewView : UserControl
  {
    #region Constructors

    public LessonsOverviewView()
    {
      InitializeComponent();

      this.DataContext = App.Resolve<LessonsOverviewViewModel>();
    }

    #endregion Constructors
  }
}