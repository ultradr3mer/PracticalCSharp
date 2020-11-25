using PracticalUi.Interfaces;
using PracticalUi.ViewModels;
using System.Windows.Controls;

namespace PracticalUi.Views
{
  /// <summary>
  /// Interaction logic for LessonView.xaml
  /// </summary>
  public partial class LessonView : Page
  {
    #region Constructors

    public LessonView()
    {
      InitializeComponent();

      this.DataContext = App.Resolve<LessonViewModel>();
    }

    #endregion Constructors
  }
}