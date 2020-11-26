using PracticalUi.Composite;
using PracticalUi.Data;
using System.Collections.ObjectModel;

namespace PracticalUi.ViewModels.Base
{
  /// <summary>
  /// The <see cref="LessonViewModelBase"/> provides functionality shared between the runtime and designtime view model.
  /// </summary>
  public class LessonViewModelBase : BindableBase<LessonData>
  {
    #region Properties

    public ObservableCollection<LessonParagraphViewModel> Paragraphs { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    #endregion Properties
  }
}