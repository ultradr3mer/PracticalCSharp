using PracticalUi.Services;
using PracticalUi.ViewModels.Base;
using Prism.Commands;
using System;

namespace PracticalUi.ViewModels
{
  /// <summary>
  /// The <see cref="LessonParagraphScriptViewModel"/> is the view model of a lesson paragraph.
  /// </summary>
  public class LessonParagraphScriptViewModel : LessonParagraphScriptViewModelBase
  {
    #region Fields

    private readonly ScriptingService scriptingService;

    #endregion Fields

    #region Constructors

    public LessonParagraphScriptViewModel(ScriptingService scriptingService)
    {
      this.ExecuteScriptCommand = new DelegateCommand(this.ExecuteScriptCommandExecute);
      this.scriptingService = scriptingService;
    }

    #endregion Constructors

    #region Properties

    public DelegateCommand ExecuteScriptCommand { get; }

    #endregion Properties

    #region Methods

    private async void ExecuteScriptCommandExecute()
    {
      try
      {
        this.Result = await this.scriptingService.Run(this.Code);
      }
      catch (Exception ex)
      {
        this.Result = ex.ToString();
      }
    }

    #endregion Methods
  }
}