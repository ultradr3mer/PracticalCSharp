using PracticalUi.Composite;
using PracticalUi.Data;
using System.Collections.ObjectModel;

namespace PracticalUi.ViewModels.Base
{
  /// <summary>
  /// The <see cref="LessonsOverviewViewModelBase"/> provides functionality shared between the runtime and designtime view model.
  /// </summary>
  public class LessonsOverviewViewModelBase : BindableBase<LessonsOverviewData>
  {
    #region Properties

    public ObservableCollection<LessonsOverviewEntryViewModel> BeginnerCourses { get; set; }
    public string TitleLabel { get; set; }

    #endregion Properties
  }
}