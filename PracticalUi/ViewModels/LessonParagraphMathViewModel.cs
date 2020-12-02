using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using PracticalUi.Services;
using PracticalUi.ViewModels.Base;
using Prism.Commands;
using System;
using System.Linq;
using System.Windows.Input;

namespace PracticalUi.ViewModels
{
  /// <summary>
  /// The <see cref="LessonParagraphMathViewModel"/> is the view model of a lesson paragraph.
  /// </summary>
  public class LessonParagraphMathViewModel : LessonParagraphMathViewModelBase
  {
    #region Fields

    private readonly ScriptingService scriptingService;
    private Func<double, double> expression;

    #endregion Fields

    #region Constructors

    public LessonParagraphMathViewModel(ScriptingService scriptingService)
    {
      this.ExecuteScriptCommand = new DelegateCommand(this.ExecuteScriptCommandExecute);
      this.scriptingService = scriptingService;

      this.PropertyChanged += this.LessonParagraphMathViewModelPropertyChanged;

      this.ResetViewCommand = new DelegateCommand(this.ResetViewCommandExecute);
    }

    #endregion Constructors

    #region Properties

    public DelegateCommand ExecuteScriptCommand { get; }
    public ICommand ResetViewCommand { get; }

    #endregion Properties

    #region Methods

    protected PlotModel GeneratePlot()
    {
      PlotModel model = new PlotModel();

      LinearAxis linearAxis1 = new LinearAxis
      {
        MajorGridlineColor = OxyColor.FromArgb(40, 0, 0, 0),
        MajorGridlineStyle = LineStyle.Solid,
        MinorGridlineColor = OxyColor.FromArgb(20, 0, 0, 0),
        MinorGridlineStyle = LineStyle.Solid,
        Minimum = this.XMin,
        Maximum = this.XMax,
        Position = AxisPosition.Bottom,
        Title = "X-axis"
      };
      model.Axes.Add(linearAxis1);

      LinearAxis linearAxis2 = new LinearAxis
      {
        MajorGridlineColor = OxyColor.FromArgb(40, 0, 0, 0),
        MajorGridlineStyle = LineStyle.Solid,
        MinorGridlineColor = OxyColor.FromArgb(20, 0, 0, 0),
        MinorGridlineStyle = LineStyle.Solid,
        Minimum = this.YMin,
        Maximum = this.YMax,
        Title = "Y-axis"
      };
      model.Axes.Add(linearAxis2);

      if (expression != null)
      {
        try
        {
          model = this.GenerateSeries(model, this.expression);
        }
        catch (Exception ex)
        {
          this.Message = ex.ToString();
        }
      }

      return model;
    }

    private async void ExecuteScriptCommandExecute()
    {
      this.Message = string.Empty;

      try
      {
        this.expression = await this.scriptingService.Run<Func<double, double>>(this.Code);

        this.PlotModel = this.GenerateSeries(this.PlotModel, this.expression);
      }
      catch (Exception ex)
      {
        this.Message = ex.ToString();
      }
    }

    private PlotModel GenerateSeries(PlotModel model, Func<double, double> expression)
    {
      model.Series.Clear();

      if (this.GraphStep <= 0)
      {
        throw new Exception("Graph step has to be greater than zero.");
      }

      LineSeries series = new LineSeries();
      for (double i = this.XMin; i < this.XMax; i += this.GraphStep)
      {
        series.Points.Add(new DataPoint(i, expression(i)));
      }

      model.Series.Add(series);
      model.InvalidatePlot(true);

      return model;
    }

    private void LessonParagraphMathViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
      string[] viewParameters = new[]
      {
        nameof(this.XMin),
        nameof(this.XMax),
        nameof(this.YMin),
        nameof(this.YMax),
        nameof(this.GridStep)
      };

      if (viewParameters.Contains(e.PropertyName))
      {
        this.ResetViewCommandExecute();
      }
    }

    private void ResetViewCommandExecute()
    {
      this.PlotModel = this.GeneratePlot();
    }

    #endregion Methods
  }
}