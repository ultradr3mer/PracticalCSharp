using PracticalUi.Composite;
using PracticalUi.Data;
using System.Windows;

namespace PracticalUi.ViewModels.Base
{
  public class LessonParagraphViewModelBase : BindableBase<LessonParagraphData>
  {
    #region Properties

    public string Code { get; set; }
    public string Result { get; set; }
    public Visibility ScriptingVisible { get; set; }
    public string Text { get; set; }

    #endregion Properties
  }
}