using PracticalUi.Composite;
using PracticalUi.ExampleViewModels;
using System.Collections.ObjectModel;

namespace PracticalUi.ViewModels.Base
{
  public class LessonsOverviewViewModelBase : BindableBase<LessonsOverviewData>
  {
    #region Properties

    public ObservableCollection<LessonsOverviewEntryViewModel> BeginnerCourses { get; set; }
    public string TitleLabel { get; set; }

    #endregion Properties
  }
}