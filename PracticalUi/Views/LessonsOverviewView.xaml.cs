using PracticalUi.ViewModels;
using System.Windows.Controls;

namespace PracticalUi.Views
{
  /// <summary>
  /// The <see cref="LessonsOverviewView"/> displays an overview over lessons.
  /// </summary>
  public partial class LessonsOverviewView : Page
  {
    #region Constructors

    public LessonsOverviewView()
    {
      this.InitializeComponent();

      this.DataContext = App.Resolve<LessonsOverviewViewModel>();
    }

    #endregion Constructors
  }
}