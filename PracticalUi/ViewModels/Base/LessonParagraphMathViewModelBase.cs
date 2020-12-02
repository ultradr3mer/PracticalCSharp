using OxyPlot;

namespace PracticalUi.ViewModels.Base
{
  /// <summary>
  /// The <see cref="LessonParagraphMathViewModelBase"/> provides functionality shared between the runtime and designtime view model.
  /// </summary>
  public class LessonParagraphMathViewModelBase : LessonParagraphViewModelBase
  {
    #region Properties

    public string Code { get; set; }
    public double GraphStep { get; set; }
    public double GridStep { get; set; }
    public string Message { get; set; }
    public PlotModel PlotModel { get; set; }
    public double XMax { get; set; }
    public double XMin { get; set; }
    public double YMax { get; set; }
    public double YMin { get; set; }

    #endregion Properties
  }
}