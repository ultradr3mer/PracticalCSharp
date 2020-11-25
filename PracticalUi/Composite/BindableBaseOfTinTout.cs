using PracticalUi.Extrensions;
using Prism.Mvvm;

namespace PracticalUi.Composite
{
  /// <summary>
  /// The <see cref="BindableBase{Tin, Tout}"/> class is an extension of the <see cref="BindableBase"/>.
  /// </summary>
  /// <typeparam name="Tin">The type of the attaced data model.</typeparam>
  /// <typeparam name="Tout">The type of the attaced data model.</typeparam>
  public class BindableBase<Tin, Tout> : BindableBase where Tout : new()
  {
    #region Fields

    private Tin attachedDataModel;

    #endregion Fields

    #region Methods

    /// <summary>
    /// Sets the data model.
    /// </summary>
    /// <param name="data">The data model to set.</param>
    public void SetDataModel(Tin data)
    {
      this.CopyPropertiesFrom(data);
      this.attachedDataModel = data;
      this.OnReadingDataModel(data);
    }

    /// <summary>
    /// Writes the content to the data model.
    /// </summary>
    /// <returns>The data model.</returns>
    public Tout WriteToDataModel()
    {
      return new Tout().CopyPropertiesFrom(this.attachedDataModel).CopyPropertiesFrom(this);
    }

    /// <summary>
    /// Gets executed when the data model is beeing read.
    /// </summary>
    /// <param name="data">The data model just read.</param>
    protected virtual void OnReadingDataModel(Tin data)
    {
    }

    #endregion Methods
  }
}