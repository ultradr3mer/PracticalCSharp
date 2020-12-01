using PracticalUi.Data;
using PracticalUi.Extrensions;
using PracticalUi.Interfaces;
using PracticalUi.ViewModels.Base;
using PracticalUi.Views;
using Prism.Commands;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
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
    private readonly IMessageDisplay messageDisplay;

    #endregion Fields

    #region Constructors

    public LessonsOverviewViewModel(IUnityContainer container, IMessageDisplay messageDisplay)
    {
      this.PasteLessonCommand = new DelegateCommand(this.PasteLessonCommandExecute);

      this.BeginnerCourses = new ObservableCollection<LessonsOverviewEntryViewModel>();
      this.container = container;
      this.messageDisplay = messageDisplay;
      this.Initialize();
    }

    #endregion Constructors

    #region Properties

    public DelegateCommand PasteLessonCommand { get; }

    #endregion Properties

    #region Methods

    private void Initialize()
    {
      this.TitleLabel = "Available Courses";

      LessonsOverviewEntryData[] beginnerCourses = new[] {
        new LessonsOverviewEntryData() { Name = "Integers", Data = Properties.Resources.IntegerLesson },
        new LessonsOverviewEntryData() { Name = "Floats", Data = Properties.Resources.FloatLesson },
        new LessonsOverviewEntryData() { Name = "Strings", Data = Properties.Resources.StringsLesson },
        new LessonsOverviewEntryData() { Name = "Expressions and algorithms", Data = Properties.Resources.ExpressionsAlgos }
      };

      this.BeginnerCourses.Clear();
      this.BeginnerCourses.AddRange(beginnerCourses.Select(o => this.container.Resolve<LessonsOverviewEntryViewModel>().GetWithDataModel(o)));
    }

    private void PasteLessonCommandExecute()
    {
      try
      {
        var json = Clipboard.GetText();
        App.Navigate<LessonView>(json);
      }
      catch (Exception exception)
      {
        this.messageDisplay.ShowMessageAsync("Error parsing clipboard content.", exception.ToString());
      }
    }

    #endregion Methods
  }
}