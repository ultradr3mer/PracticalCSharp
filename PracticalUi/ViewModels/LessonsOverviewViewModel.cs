using PracticalUi.Data;
using PracticalUi.Extrensions;
using System.Collections.ObjectModel;
using System.Linq;
using Unity;

namespace PracticalUi.ViewModels
{
  internal class LessonsOverviewViewModel : LessonsOverviewViewModelBase
  {
    #region Fields

    private readonly IUnityContainer container;

    #endregion Fields

    #region Constructors

    public LessonsOverviewViewModel(IUnityContainer container)
    {
      this.BeginnerCourses = new ObservableCollection<LessonsOverviewEntryViewModel>();
      this.container = container;

      this.Initialize();
    }

    #endregion Constructors

    #region Methods

    private void Initialize()
    {
      this.TitleLabel = "Available Courses";

      var beginnerCourses = new[] {
        new CourseData() { Name = "Integers", Data = Properties.Resources.IntegerLesson },
        new CourseData() { Name = "Floats", Data = Properties.Resources.FloatLesson }
      };

      this.BeginnerCourses.Clear();
      this.BeginnerCourses.AddRange(beginnerCourses.Select(o => container.Resolve<LessonsOverviewEntryViewModel>().GetWithDataModel(o)));
    }

    #endregion Methods
  }
}