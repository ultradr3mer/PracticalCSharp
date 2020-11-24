namespace DotNetCore.ViewModels
{
  using System;
  using System.ComponentModel;
  using System.Linq;
  using System.Windows.Input;
  using DataModel;
  using Prism.Commands;
  using Prism.Mvvm;
  using Services;
  using Unity;

  public class MainWindowViewModel : BindableBase
  {
    #region Fields

    private readonly IUnityContainer container;
    private readonly DataPersistingService persistingService;

    private string title = "Prism Application";

    private ICommand propAddCommand;

    private ICommand propSaveCommand;

    private BindingList<ScriptViewModel> propScripts;

    #endregion

    #region Constructors

    public MainWindowViewModel(IUnityContainer container, DataPersistingService persistingService)
    {
      this.container = container;
      this.persistingService = persistingService;

      this.AddCommand = new DelegateCommand(this.AddCommandExecute);
      this.SaveCommand = new DelegateCommand(this.SaveCommandExecute);

      this.Scripts = new BindingList<ScriptViewModel>();
    }

    #endregion

    #region Properties

    public ICommand AddCommand
    {
      get { return this.propAddCommand; }
      set { this.SetProperty(ref this.propAddCommand, value); }
    }

    public ICommand SaveCommand
    {
      get { return this.propSaveCommand; }
      set { this.SetProperty(ref this.propSaveCommand, value); }
    }

    public BindingList<ScriptViewModel> Scripts
    {
      get { return this.propScripts; }
      set { this.SetProperty(ref this.propScripts, value); }
    }

    public string Title
    {
      get { return this.title; }
      set { this.SetProperty(ref this.title, value); }
    }

    #endregion

    #region Methods

    private void AddCommandExecute()
    {
      this.Scripts.Add(this.container.Resolve<ScriptViewModel>());
    }

    private void SaveCommandExecute()
    {
      var container = new ContainerModel()
      {
        Scripts = this.Scripts.Select(o => o.AttatchedDatamodel).ToList()
      };

      this.persistingService.Save(container);
    }

    #endregion
  }
}