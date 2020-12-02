using PracticalUi.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace PracticalUi.Composite
{
  /// <summary>
  /// The <see cref="LessonParagraphTemplateSelector"/> class selects the template for the lesson paragraphs.
  /// </summary>
  public class LessonParagraphTemplateSelector : DataTemplateSelector
  {
    #region Properties

    public DataTemplate CodeTemplate { get; set; }
    public DataTemplate MathTemplate { get; set; }
    public DataTemplate TextTemplate { get; set; }

    #endregion Properties

    #region Methods

    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
      if (item is LessonParagraphScriptViewModel)
      {
        return this.CodeTemplate;
      }

      if(item is LessonParagraphMathViewModel)
      {
        return this.MathTemplate;
      }

      return this.TextTemplate;
    }

    #endregion Methods
  }
}