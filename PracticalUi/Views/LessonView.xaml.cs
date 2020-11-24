using Newtonsoft.Json;
using PracticalUi.ExampleViewModels;
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

      this.DataContext = JsonConvert.DeserializeObject<IntegerLessonViewModel>(Properties.Resources.IntegerLesson);
    }

    #endregion Constructors
  }
}