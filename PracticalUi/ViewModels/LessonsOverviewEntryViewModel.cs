using PracticalUi.Composite;
using PracticalUi.Data;
using PracticalUi.Views;
using Prism.Commands;

namespace PracticalUi.ViewModels
{
  /// <summary>
  /// The <see cref="LessonsOverviewEntryViewModel"/> is the view model of a entry in the lesson overview.
  /// </summary>
  public class LessonsOverviewEntryViewModel : BindableBase<LessonsOverviewEntryData>
  {
    #region Constructors

    public LessonsOverviewEntryViewModel()
    {
      this.CourseClickedCommand = new DelegateCommand(this.CourseClickedCommandExecute);
    }

    #endregion Constructors

    #region Properties

    public DelegateCommand CourseClickedCommand { get; }
    public string Data { get; set; }
    public string Name { get; set; }

    #endregion Properties

    #region Methods

    private void CourseClickedCommandExecute()
    {
      App.Navigate<LessonView>(this.Data);
    }

    #endregion Methods
  }
}