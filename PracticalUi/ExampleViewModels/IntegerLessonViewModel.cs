using PracticalUi.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalUi.ExampleViewModels
{
  class IntegerLessonViewModel
  {
    public string Title { get; set; } = "Kickstart with the integer data type";

    public ObservableCollection<LessonEntryViewModel> Paragraphs { get; set; } = new ObservableCollection<LessonEntryViewModel>()
    {
      new LessonEntryViewModel() { Text = "Programming does not need to be complicated. It can be as easy as adding two and two. Try it out yourself.", Code = "2 + 2"},
      new LessonEntryViewModel() { Text = "Numbers without a decimal point are aoutomatically of the type Int32. You can retrive the type by calling the GetType() function. It works for everything in C#.", Code = "(2).GetType()"},
      new LessonEntryViewModel() { Text = "Another function that is available for everythin in C# is ToString. It creates a string representation of what it is called on.", Code = "(2).ToString()"},
      new LessonEntryViewModel() { Text = "Let us stay with whole numbers for a moment. The Integer data type contains 32 bits and can be noted as int or Int32"},
    };
  }
}
