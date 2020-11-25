using Prism.Mvvm;

namespace PracticalUi.ViewModels
{
  /// <summary>
  /// The <see cref="MainWindowViewModel"/> class is the view model of the main view.
  /// </summary>
  public class MainWindowViewModel : BindableBase
  {
    #region Constructors

    public MainWindowViewModel()
    {
    }

    #endregion Constructors

    #region Properties

    public string Title { get; set; } = "Practical C#";

    #endregion Properties
  }
}