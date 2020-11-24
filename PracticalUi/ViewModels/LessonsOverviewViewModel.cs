using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;

namespace PracticalUi.ViewModels
{
  internal class LessonsOverviewViewModel : LessonsOverviewViewModelBase
  {
    #region Constructors

    public LessonsOverviewViewModel()
    {
      this.Initialize();
    }

    private void Initialize()
    {
      this.TitleLabel = "Available Courses";
      this.BeginnerCourses = new ObservableCollection<LessonsOverviewEntryViewModel>()
      {
        new LessonsOverviewEntryViewModel(){ Name = "Integers"},
        new LessonsOverviewEntryViewModel(){ Name = "Floats"}
      };
    }

    #endregion Constructors

  }
}