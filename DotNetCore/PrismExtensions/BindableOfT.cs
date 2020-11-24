namespace DotNetCore.PrismExtensions
{
  using System.Collections.Generic;
  using System.Reflection;
  using Prism.Mvvm;

  public abstract class BindableBase<T> : BindableBase
  {
    #region Fields

    private T attatchedDataModel;

    private readonly List<(PropertyInfo propBindable, PropertyInfo propDataModel)> props;

    #endregion

    #region Constructors

    public BindableBase()
    {
      var propsDataModel = typeof(T).GetProperties();

      this.props = new List<(PropertyInfo propBindable, PropertyInfo propDataModel)>();
      foreach (var propDataModel in propsDataModel)
      {
        var propBindable = this.GetType().GetProperty(propDataModel.Name);
        this.props.Add((propBindable, propDataModel));
      }
    }

    #endregion

    #region Properties

    public T AttatchedDatamodel
    {
      get
      {
        foreach (var prop in this.props)
        {
          var propValue = prop.propBindable.GetValue(this);
          prop.propDataModel.SetValue(this.attatchedDataModel, propValue);
        }

        return this.attatchedDataModel;
      }

      set
      {
        this.attatchedDataModel = value;

        foreach (var prop in this.props)
        {
          var propValue = prop.propDataModel.GetValue(value);
          prop.propBindable.SetValue(this, propValue);
        }
      }
    }

    #endregion
  }
}