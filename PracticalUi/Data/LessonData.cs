using System.Collections.Generic;

namespace PracticalUi.Data
{
  /// <summary>
  /// The <see cref="LessonData"/> contains all data of a lesson.
  /// </summary>
  public class LessonData
  {
    #region Properties

    public string Description { get; set; }
    public string Title { get; set; }
    public List<LessonParagraphData> Paragraphs { get; set; }

    #endregion Properties
  }
}