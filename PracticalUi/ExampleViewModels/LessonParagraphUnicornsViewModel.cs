using PracticalUi.ViewModels;

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
    }

    #endregion Properties
  }
}