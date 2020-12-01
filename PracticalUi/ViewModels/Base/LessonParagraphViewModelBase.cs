﻿using PracticalUi.Composite;
using PracticalUi.Data;
using System.Windows;

namespace PracticalUi.ViewModels.Base
{
  /// <summary>
  /// The <see cref="LessonParagraphViewModelBase"/> provides functionality shared between the runtime and designtime view model.
  /// </summary>
  public class LessonParagraphViewModelBase : BindableBase<LessonParagraphData>
  {
    #region Properties

    public string Code { get; set; }
    public string Result { get; set; }
    public Visibility ScriptingVisible { get; set; } = Visibility.Visible;
    public string Text { get; set; }

    #endregion Properties
  }
}