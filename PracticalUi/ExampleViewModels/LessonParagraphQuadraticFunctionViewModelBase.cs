using PracticalUi.Controls;
using PracticalUi.ViewModels.Base;

namespace PracticalUi.ExampleViewModels
{
  /// <summary>
  /// Example view model to test the <see cref="LessonParagraphMathView"/>
  /// </summary>
  internal class LessonParagraphQuadraticFunctionViewModelBase : LessonParagraphMathViewModelBase
  {
    #region Constructors

    public LessonParagraphQuadraticFunctionViewModelBase()
    {
      this.Text = "Check out this quadratic function:";
      this.Code = "x => x * x";
      this.XMin = -5;
      this.XMax = 5;
      this.YMin = -5;
      this.YMax = 5;
      this.GraphStep = 0.01;
      this.GridStep = 1;
      this.Message = "Error message here";
    }

    #endregion Constructors
  }
}