namespace PracticalUi.ViewModels.Base
{
  /// <summary>
  /// The <see cref="LessonParagraphScriptViewModelBase"/> provides functionality shared between the runtime and designtime view model.
  /// </summary>
  public class LessonParagraphScriptViewModelBase : LessonParagraphViewModelBase
  {
    #region Properties

    public string Code { get; set; }
    public string Result { get; set; }

    #endregion Properties
  }
}