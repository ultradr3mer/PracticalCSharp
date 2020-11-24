using Prism.Mvvm;

namespace PracticalUi.ViewModels
{
  internal class LessonEntryViewModel : BindableBase
  {
    #region Properties

    public string Text { get; set; }
    public string Code { get; set; }

    #endregion Properties
  }
}