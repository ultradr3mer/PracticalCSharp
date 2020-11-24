using PracticalUi.Data;
using PracticalUi.Services;
using Prism.Commands;
using System;
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

    protected override void OnReadingDataModel(LessonParagraphData data)
    {
      this.ScriptingVisible = data.IsScriptingVisible ? Visibility.Visible : Visibility.Collapsed;
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
      catch(Exception ex)
      {
        this.Result = ex.ToString();
      }
    }

    #endregion Methods
  }
}