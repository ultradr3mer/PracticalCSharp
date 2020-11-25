using Newtonsoft.Json;
using PracticalUi.Data;
using PracticalUi.Extrensions;
using Prism.Regions;
using System.Collections.ObjectModel;
using System.Linq;
using Unity;

namespace PracticalUi.ViewModels
{
  public class LessonViewModel : LessonViewModelBase, INavigationAware
  {
    #region Fields

    private readonly IUnityContainer unityContainer;

    #endregion Fields

    #region Constructors

    public LessonViewModel(IUnityContainer unityContainer)
    {
      this.unityContainer = unityContainer;

      this.Paragraphs = new ObservableCollection<LessonParagraphViewModel>();

      this.Title = "asd";

      this.LessonContent = Properties.Resources.IntegerLesson;
    }

    #endregion Constructors

    #region Properties

    public string LessonContent { get; set; }

    #endregion Properties

    #region Methods

    public void Initialize()
    {
      var data = JsonConvert.DeserializeObject<LessonData>(this.LessonContent);
      this.SetDataModel(data);
    }

    public bool IsNavigationTarget(NavigationContext navigationContext)
    {
      return true;
    }

    public void OnNavigatedFrom(NavigationContext navigationContext)
    {
    }

    public void OnNavigatedTo(NavigationContext navigationContext)
    {
      this.Initialize();
    }

    protected override void OnReadingDataModel(LessonData data)
    {
      this.Paragraphs.AddRange(data.Paragraphs.Select(o => this.unityContainer.Resolve<LessonParagraphViewModel>().GetWithDataModel(o)));
    }

    #endregion Methods
  }
}