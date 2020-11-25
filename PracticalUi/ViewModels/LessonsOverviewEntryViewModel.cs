using PracticalUi.Composite;
using PracticalUi.Data;
using PracticalUi.Views;
using Prism.Commands;
using Prism.Regions;
using System;

namespace PracticalUi.ViewModels
{
  public class LessonsOverviewEntryViewModel : BindableBase<LessonsOverviewEntryData>
  {
    #region Fields

    private readonly IRegionManager regionManager;
    private readonly LessonViewModel lessonViewModel;

    #endregion Fields

    #region Constructors

    public LessonsOverviewEntryViewModel(IRegionManager regionManager, LessonViewModel lessonViewModel)
    {
      this.lessonViewModel = lessonViewModel;
      this.CourseClickedCommand = new DelegateCommand(this.CourseClickedCommandExecute);
      this.regionManager = regionManager;
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
      this.lessonViewModel.LessonContent = this.Data;

      regionManager.RequestNavigate("MainRegion", new Uri(nameof(LessonView), UriKind.Relative));
    }

    #endregion Methods
  }
}