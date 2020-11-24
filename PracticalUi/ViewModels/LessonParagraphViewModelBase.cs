﻿using PracticalUi.Composite;
using PracticalUi.Data;
using Prism.Mvvm;
using System.Windows;

namespace PracticalUi.ViewModels
{
  internal class LessonParagraphViewModelBase : BindableBase<LessonParagraphData>
  {
    #region Properties

    public string Code { get; set; }
    public string Result { get; set; }
    public string Text { get; set; }
    public Visibility ScriptingVisible { get; set; }

    #endregion Properties
  }
}