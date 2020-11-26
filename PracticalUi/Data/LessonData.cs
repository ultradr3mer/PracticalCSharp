using System.Collections.Generic;

namespace PracticalUi.Data
{
  /// <summary>
  /// The <see cref="LessonData"/> contains all data of a lesson.
  /// </summary>
  public class LessonData
  {
    #region Properties

    public List<LessonParagraphData> Paragraphs { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    #endregion Properties
  }
}