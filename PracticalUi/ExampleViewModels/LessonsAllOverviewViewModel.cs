using PracticalUi.ViewModels;
using System.Collections.ObjectModel;

namespace PracticalUi.ExampleViewModels
{
  public class LessonsAllOverviewViewModel : LessonsOverviewViewModelBase
  {
    #region Constructors

    public LessonsAllOverviewViewModel()
    {
      this.TitleLabel = "All Available Cources";
      this.BeginnerCourses = new ObservableCollection<LessonsOverviewEntryViewModel>()
      {
        new LessonsOverviewEntryViewModel(){ Name = "Integers"},
        new LessonsOverviewEntryViewModel(){ Name = "Floats"}
      };
    }

    #endregion Constructors
  }
}