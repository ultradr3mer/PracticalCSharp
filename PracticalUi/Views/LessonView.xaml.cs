using PracticalUi.ViewModels;
using Prism.Regions;
using System.Windows.Controls;

namespace PracticalUi.Views
{
  /// <summary>
  /// Interaction logic for LessonView.xaml
  /// </summary>
  public partial class LessonView : UserControl
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

    #endregion Methods
  }
}