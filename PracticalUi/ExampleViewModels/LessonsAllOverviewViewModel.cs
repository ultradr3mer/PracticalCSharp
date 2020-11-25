using PracticalUi.ViewModels;
using PracticalUi.ViewModels.Base;
using System.Collections.ObjectModel;

namespace PracticalUi.ExampleViewModels
{
  /// <summary>
  /// The <see cref="LessonsAllOverviewViewModel"/> class is an example for a <see cref="LessonsOverviewViewModel"/>.
  /// </summary>
  public class LessonsAllOverviewViewModel : LessonsOverviewViewModelBase
  {
    #region Constructors

    public LessonsAllOverviewViewModel()
    {
      this.TitleLabel = "All Available Cources";
      this.BeginnerCourses = new ObservableCollection<LessonsOverviewEntryViewModel>()
      {
        new LessonsOverviewEntryViewModel() {Name = "Integer"},
        new LessonsOverviewEntryViewModel() {Name = "Floats"}
      };
    }

    #endregion Constructors
  }
}