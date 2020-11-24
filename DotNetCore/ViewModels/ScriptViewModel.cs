namespace DotNetCore.ViewModels
{
  using System;
  using System.Windows.Input;
  using global::Prism.Commands;
  using Models;
  using DotNetCore.DataModel;
    using DotNetCore.PrismExtensions;

  public class ScriptViewModel : BindableBase<ScriptModel>
  {
    #region Fields

    private readonly ScriptingService service;

    private ICommand propExecuteCommand;

    private string propResult;

    private string propScript;

    #endregion

    #region Constructors

    public ScriptViewModel(ScriptingService model)
    {
      this.ExecuteCommand = new DelegateCommand(this.ExecuteCommandExecute);
      this.service = model;

      this.AttatchedDatamodel = new ScriptModel();
    }

    #endregion

    #region Properties

    public ICommand ExecuteCommand
    {
      get { return this.propExecuteCommand; }
      set { this.SetProperty(ref this.propExecuteCommand, value); }
    }

    public string Result
    {
      get { return this.propResult; }
      set { this.SetProperty(ref this.propResult, value); }
    }

    public string Script
    {
      get { return this.propScript; }
      set { this.SetProperty(ref this.propScript, value); }
    }

    #endregion

    #region Methods

    private async void ExecuteCommandExecute()
    {
      try
      {
        this.Result = await service.Run(this.Script);
      }
      catch (Exception e)
      {
        this.Result = e.Message;
      }
    }

    #endregion
  }
}