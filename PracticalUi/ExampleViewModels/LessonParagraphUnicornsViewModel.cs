using PracticalUi.ViewModels;
using PracticalUi.ViewModels.Base;

namespace PracticalUi.ExampleViewModels
{
  /// <summary>
  /// The <see cref="LessonParagraphUnicornsViewModel"/> class is an example for a <see cref="LessonParagraphViewModel"/>.
  /// </summary>
  internal class LessonParagraphUnicornsViewModel : LessonParagraphScriptViewModelBase
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