using PracticalUi.ViewModels;
using System.Windows.Controls;

namespace PracticalUi.Views
{
  /// <summary>
  /// The <see cref="LessonView"/> displays a lesson.
  /// </summary>
  public partial class LessonView : Page
  {
    #region Constructors

    public LessonView()
    {
      this.InitializeComponent();

      this.DataContext = App.Resolve<LessonViewModel>();
    }

    #endregion Constructors
  }
}