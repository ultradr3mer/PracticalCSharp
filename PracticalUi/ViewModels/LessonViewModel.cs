using Newtonsoft.Json;
using PracticalUi.Data;
using PracticalUi.Extrensions;
using PracticalUi.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;
using Unity;
using PracticalUi.Interfaces;

namespace PracticalUi.ViewModels
{
  public class LessonViewModel : LessonViewModelBase, INavigationAware
  {
    #region Fields

    private readonly IUnityContainer unityContainer;
    private string lessonContent;

    #endregion Fields

    #region Constructors

    public LessonViewModel(IUnityContainer unityContainer)
    {
      this.unityContainer = unityContainer;

      this.Paragraphs = new ObservableCollection<LessonParagraphViewModel>();
    }

    #endregion Constructors

    #region Methods

    public void Initialize()
    {
      var data = JsonConvert.DeserializeObject<LessonData>(this.lessonContent);
      this.SetDataModel(data);
    }

    public void OnNavigatingTo(object args)
    {
      this.lessonContent = args as string;
      this.Initialize();
    }

    protected override void OnReadingDataModel(LessonData data)
    {
      this.Paragraphs.Clear();
      this.Paragraphs.AddRange(data.Paragraphs.Select(o => this.unityContainer.Resolve<LessonParagraphViewModel>().GetWithDataModel(o)));
    }

    #endregion Methods
  }
}