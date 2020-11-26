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
      T data = this.attachedDataModel.CopyPropertiesFrom(this);
      return this.OnWritingDataModel(data);
    }

    /// <summary>
    /// Gets executed when the data model is beeing read.
    /// </summary>
    /// <param name="data">The data model just read.</param>
    protected virtual void OnReadingDataModel(T data)
    {
    }

    /// <summary>
    /// Gets executed when the data model is beeing written.
    /// </summary>
    /// <param name="data">The data with automatic written properties.</param>
    protected virtual T OnWritingDataModel(T data)
    {
      return data;
    }

    #endregion Methods
  }
}