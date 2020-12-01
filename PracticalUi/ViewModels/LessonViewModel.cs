﻿using Newtonsoft.Json;
using PracticalUi.Data;
using PracticalUi.Extrensions;
using PracticalUi.Interfaces;
using PracticalUi.ViewModels.Base;
using Prism.Commands;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Unity;

namespace PracticalUi.ViewModels
{
  /// <summary>
  /// The <see cref="LessonViewModel"/> is the view model of a lesson.
  /// </summary>
  public class LessonViewModel : LessonViewModelBase, INavigationAware
  {
    #region Fields

    private readonly IUnityContainer unityContainer;
    private readonly IMessageDisplay messageDisplay;

    #endregion Fields

    #region Constructors

    public LessonViewModel(IUnityContainer unityContainer, IMessageDisplay messageDisplay)
    {
      this.unityContainer = unityContainer;
      this.messageDisplay = messageDisplay;

      this.Paragraphs = new ObservableCollection<LessonParagraphViewModel>();

      this.CopyCommand = new DelegateCommand(this.CopyCommandExecute);
      this.PasteCommand = new DelegateCommand(this.PasteCommandExecute);
    }

    #endregion Constructors

    #region Properties

    public DelegateCommand CopyCommand { get; }

    public DelegateCommand PasteCommand { get; }

    #endregion Properties

    #region Methods

    public void OnNavigatingTo(object args)
    {
      if (!(args is string argsString))
      {
        return;
      }

      this.LoadFromString(argsString);
    }

    protected override void OnReadingDataModel(LessonData data)
    {
      this.Paragraphs.Clear();
      this.Paragraphs.AddRange(data.Paragraphs.Select(o => this.unityContainer.Resolve<LessonParagraphViewModel>().GetWithDataModel(o)));
    }

    protected override LessonData OnWritingDataModel(LessonData data)
    {
      data.Paragraphs = this.Paragraphs.Select(o => o.WriteToDataModel()).ToList();

      return data;
    }

    private void CopyCommandExecute()
    {
      var json = JsonConvert.SerializeObject(this.WriteToDataModel(), Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
      Clipboard.SetText(json);
    }

    private void LoadFromString(string lessonContent)
    {
      LessonData data = JsonConvert.DeserializeObject<LessonData>(lessonContent);
      this.SetDataModel(data);
    }

    private void PasteCommandExecute()
    {
      try
      {
        var json = Clipboard.GetText();
        this.LoadFromString(json);
      }
      catch (Exception exception)
      {
        this.messageDisplay.ShowMessageAsync("Error parsing clipboard content.", exception.ToString());
      }
    }

    #endregion Methods
  }
}