//using PracticalUi.Composite;
//using PracticalUi.Data;
//using PracticalUi.Views;
//using Prism.Commands;
//using Prism.Regions;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticalUi.ViewModels
//{
//  class CourseEntryViewModel : BindableBase<CourseData>
//  {
//    #region Fields

//    private readonly IRegionManager regionManager;

//    #endregion Fields

//    #region Constructors

//    public CourseEntryViewModel(IRegionManager regionManager)
//    {
//      this.CourseClickedCommand = new DelegateCommand(this.CourseClickedCommandExecute);
//      this.regionManager = regionManager;
//    }

//    #endregion Constructors

//    #region Properties

//    public DelegateCommand CourseClickedCommand { get; }

//    public string Data { get; set; }

//    public string Name { get; set; }

//    #endregion Properties

//    #region Methods

//    private void CourseClickedCommandExecute()
//    {
//      regionManager.RequestNavigate("MainRegion", new Uri(nameof(LessonView), UriKind.Relative));

//    }

//    #endregion Methods

//  }
//}
