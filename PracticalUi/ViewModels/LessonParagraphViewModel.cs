using PracticalUi.Services;
using Prism.Commands;
using System.Windows;

namespace PracticalUi.ViewModels
{
  internal class LessonParagraphViewModel : LessonParagraphViewModelBase
  {
    #region Fields

    private readonly ScriptingService scriptingService;

    #endregion Fields

    #region Constructors

    public LessonParagraphViewModel(ScriptingService scriptingService)
    {
      this.ExecuteScriptCommand = new DelegateCommand(this.ExecuteScriptCommandExecute);
      this.scriptingService = scriptingService;
    }

    #endregion Constructors

    #region Properties

    public DelegateCommand ExecuteScriptCommand { get; }

    public Visibility ScriptingVisible { get; set; }

    #endregion Properties

    #region Methods

    private async void ExecuteScriptCommandExecute()
    {
      this.Result = await this.scriptingService.Run(this.Code);
    }

    #endregion Methods
  }
}