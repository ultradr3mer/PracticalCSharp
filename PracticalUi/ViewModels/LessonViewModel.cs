using Newtonsoft.Json;
using PracticalUi.Data;
using PracticalUi.Extrensions;
using PracticalUi.Interfaces;
using PracticalUi.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;
using Unity;

namespace PracticalUi.ViewModels
{
  /// <summary>
  /// The <see cref="LessonViewModel"/> is the view model of a lesson.
  /// </summary>
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
      LessonData data = JsonConvert.DeserializeObject<LessonData>(this.lessonContent);
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