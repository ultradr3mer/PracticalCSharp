using PracticalUi.ViewModels;
using System.Collections.ObjectModel;
using Unity;

namespace PracticalUi.ExampleViewModels
{
  public class LessonsAllOverviewViewModel : LessonsOverviewViewModelBase
  {
    #region Constructors

    public LessonsAllOverviewViewModel(IUnityContainer unityContainer)
    {
      this.TitleLabel = "All Available Cources";
      this.BeginnerCourses = new ObservableCollection<LessonsOverviewEntryViewModel>()
      {
        unityContainer.Resolve<LessonsOverviewEntryViewModel>(),
        unityContainer.Resolve<LessonsOverviewEntryViewModel>()
      };

      this.BeginnerCourses[0].Name = "Integer";
      this.BeginnerCourses[1].Name = "Floats";
    }

    #endregion Constructors
  }
}