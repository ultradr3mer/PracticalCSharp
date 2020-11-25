using PracticalUi.ViewModels;
using PracticalUi.ViewModels.Base;
using System.Collections.ObjectModel;
using Unity;

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
        new LessonsOverviewEntryViewModel(null,null){Name = "Integer"},
        new LessonsOverviewEntryViewModel(null,null){Name = "Floats"}
      };
    }

    #endregion Constructors
  }
}