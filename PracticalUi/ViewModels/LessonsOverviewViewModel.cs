using PracticalUi.Data;
using PracticalUi.Extrensions;
using PracticalUi.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;
using Unity;

namespace PracticalUi.ViewModels
{
  /// <summary>
  /// The <see cref="LessonsOverviewViewModel"/> is the view model of the lesson overview.
  /// </summary>
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

      LessonsOverviewEntryData[] beginnerCourses = new[] {
        new LessonsOverviewEntryData() { Name = "Integers", Data = Properties.Resources.IntegerLesson },
        new LessonsOverviewEntryData() { Name = "Floats", Data = Properties.Resources.FloatLesson }
      };

      this.BeginnerCourses.Clear();
      this.BeginnerCourses.AddRange(beginnerCourses.Select(o => this.container.Resolve<LessonsOverviewEntryViewModel>().GetWithDataModel(o)));
    }

    #endregion Methods
  }
}