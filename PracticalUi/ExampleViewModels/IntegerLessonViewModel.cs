using PracticalUi.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace PracticalUi.ExampleViewModels
{
  internal class IntegerLessonViewModel : LessonViewModelBase
  {
    #region Constructors

    public IntegerLessonViewModel()
    {
      this.Paragraphs = new ObservableCollection<LessonParagraphViewModel>()
      {
        new LessonParagraphViewModel(null) { Text = "Programming does not need to be complicated. It can be as easy as adding two and two. Try it out yourself.", Code = "2 + 2", ScriptingVisible = Visibility.Visible },
        new LessonParagraphViewModel(null) { Text = "Numbers without a decimal point are aoutomatically of the type Int32. You can retrive the type by calling the GetType() function. It works for everything in C#.", Code = "(2).GetType()", ScriptingVisible = Visibility.Visible },
        new LessonParagraphViewModel(null) { Text = "Another function that is available for everythin in C# is ToString. It creates a string representation of what it is called on.", Code = "(2).ToString()", ScriptingVisible = Visibility.Visible },
        new LessonParagraphViewModel(null) { Text = "Let us stay with whole numbers for a moment. The Integer data type contains 32 bits and can be noted as int or Int32.", ScriptingVisible = Visibility.Collapsed },
        new LessonParagraphViewModel(null) { Text = "The type can be stated explicitly by wrinting (int) or (Int32) in front of the number.", Code = "(int)32", ScriptingVisible = Visibility.Visible },
      };

      this.Title = "Kickstart with the integer data type";
    }

    #endregion Constructors
  }
}