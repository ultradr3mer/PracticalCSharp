using PracticalUi.Composite;
using PracticalUi.Data;

namespace PracticalUi.ViewModels.Base
{
  /// <summary>
  /// The <see cref="LessonParagraphViewModelBase"/> provides functionality shared between the runtime and designtime view model.
  /// </summary>
  public class LessonParagraphViewModelBase : BindableBase<LessonParagraphData>
  {
    #region Properties

    public string Text { get; set; }

    #endregion Properties
  }
}