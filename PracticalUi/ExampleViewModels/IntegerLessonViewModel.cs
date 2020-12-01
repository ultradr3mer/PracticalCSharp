using PracticalUi.ViewModels;
using PracticalUi.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows;

namespace PracticalUi.ExampleViewModels
{
  /// <summary>
  /// The <see cref="IntegerLessonViewModel"/> contains an example lesson.
  /// </summary>
  internal class IntegerLessonViewModel : LessonViewModelBase
  {
    #region Constructors

    public IntegerLessonViewModel()
    {
      this.Paragraphs = new ObservableCollection<LessonParagraphViewModelBase>()
      {
        new LessonParagraphScriptViewModel(null) { Text = "Programming does not need to be complicated. It can be as easy as adding two and two. Try it out yourself.", Code = "2 + 2" },
        new LessonParagraphScriptViewModel(null) { Text = "Numbers without a decimal point are aoutomatically of the type Int32. You can retrive the type by calling the GetType() function. It works for everything in C#.", Code = "(2).GetType()" },
        new LessonParagraphScriptViewModel(null) { Text = "Another function that is available for everythin in C# is ToString. It creates a string representation of what it is called on.", Code = "(2).ToString()" },
        new LessonParagraphViewModel(null) { Text = "Let us stay with whole numbers for a moment. The Integer data type contains 32 bits and can be noted as int or Int32." },
        new LessonParagraphScriptViewModel(null) { Text = "The type can be stated explicitly by wrinting (int) or (Int32) in front of the number.", Code = "(int)32" },
      };

      this.Description = "Kickstart with the integer data type";

      this.Title = "Integers";
    }

    #endregion Constructors
  }
}