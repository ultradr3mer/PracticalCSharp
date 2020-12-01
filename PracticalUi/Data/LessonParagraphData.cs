using PracticalUi.Enums;
using System;
using System.Runtime.Serialization;

namespace PracticalUi.Data
{
  /// <summary>
  /// The <see cref="LessonParagraphData"/> contains all data of a lesson paragraph.
  /// </summary>
  [DataContract]
  public class LessonParagraphData
  {
    #region Properties

    public ParagraphType ParagraphType { get; set; } = ParagraphType.Text;

    [DataMember(Name = "ParagraphType")]
    public string ParagraphTypeString
    {
      get => this.ParagraphType.ToString();
      set => this.ParagraphType = (ParagraphType)Enum.Parse(typeof(ParagraphType), value);
    }

    [DataMember]
    public string Text { get; set; }

    [DataMember]
    public string Code { get; set; }

    #endregion Properties
  }
}