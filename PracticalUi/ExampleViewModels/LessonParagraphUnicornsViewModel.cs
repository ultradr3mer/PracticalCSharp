using PracticalUi.ViewModels.Base;

namespace PracticalUi.ExampleViewModels
{
  internal class LessonParagraphUnicornsViewModel : LessonParagraphViewModelBase
  {
    #region Properties

    public LessonParagraphUnicornsViewModel()
    {
      this.Text = "I like unicorns";
      this.Code = "while(true) unicorns.like();";
      this.Result = "Runns forever;";
      this.ScriptingVisible = System.Windows.Visibility.Visible;
    }

    #endregion Properties
  }
}