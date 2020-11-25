using PracticalUi.Extrensions;
using Prism.Mvvm;

namespace PracticalUi.Composite
{
  /// <summary>
  /// The <see cref="BindableBase{T}"/> class is an extension of the <see cref="BindableBase"/>.
  /// </summary>
  /// <typeparam name="T">The type of the attaced data model.</typeparam>
  public class BindableBase<T> : BindableBase
  {
    #region Fields

    private T attachedDataModel;

    #endregion Fields

    #region Methods

    /// <summary>
    /// Sets the data model.
    /// </summary>
    /// <param name="data">The data model to set.</param>
    public void SetDataModel(T data)
    {
      this.CopyPropertiesFrom(data);
      this.attachedDataModel = data;
      this.OnReadingDataModel(data);
    }

    /// <summary>
    /// Writes the content to the data model.
    /// </summary>
    /// <returns>The data model.</returns>
    public T WriteToDataModel()
    {
      return this.attachedDataModel.CopyPropertiesFrom(this);
    }

    /// <summary>
    /// Gets executed when the data model is beeing read.
    /// </summary>
    /// <param name="data">The data model just read.</param>
    protected virtual void OnReadingDataModel(T data)
    {
    }

    #endregion Methods
  }
}