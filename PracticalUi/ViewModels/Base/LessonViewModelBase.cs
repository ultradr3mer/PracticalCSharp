﻿using PracticalUi.Composite;
using PracticalUi.Data;
using System.Collections.ObjectModel;

namespace PracticalUi.ViewModels.Base
{
  public class LessonViewModelBase : BindableBase<LessonData>
  {
    #region Properties

    public ObservableCollection<LessonParagraphViewModel> Paragraphs { get; set; }

    public string Title { get; set; }

    #endregion Properties
  }
}