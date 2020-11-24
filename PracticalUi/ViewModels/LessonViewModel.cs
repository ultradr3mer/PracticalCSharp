using Newtonsoft.Json;
using PracticalUi.Data;
using PracticalUi.Extrensions;
using System.Collections.ObjectModel;
using System.Linq;
using Unity;

namespace PracticalUi.ViewModels
{
  internal class LessonViewModel : LessonViewModelBase
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
    }

    #endregion Constructors

    #region Methods

    public void Initialize()
    {
      var json = Properties.Resources.IntegerLesson;
      var data = JsonConvert.DeserializeObject<LessonData>(json);
      this.SetDataModel(data);
    }

    protected override void OnReadingDataModel(LessonData data)
    {
      this.Paragraphs.AddRange(data.Paragraphs.Select(o => this.unityContainer.Resolve<LessonParagraphViewModel>().GetWithDataModel(o)));
    }

    #endregion Methods
  }
}