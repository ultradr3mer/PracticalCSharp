using PracticalUi.Services;
using PracticalUi.ViewModels.Base;
using Prism.Commands;

namespace PracticalUi.ViewModels
{
  /// <summary>
  /// The <see cref="LessonParagraphViewModel"/> is the view model of a lesson paragraph.
  /// </summary>
  public class LessonParagraphViewModel : LessonParagraphViewModelBase
  {
    #region Fields

    private readonly ScriptingService scriptingService;

    #endregion Fields

    #region Constructors

    public LessonParagraphViewModel(ScriptingService scriptingService)
    {
      this.scriptingService = scriptingService;
    }

    #endregion Constructors

    #region Properties

    public DelegateCommand ExecuteScriptCommand { get; }

    #endregion Properties
  }
}