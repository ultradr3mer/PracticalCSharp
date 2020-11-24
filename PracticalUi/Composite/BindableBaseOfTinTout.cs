﻿using PracticalUi.Extrensions;
using Prism.Mvvm;

namespace PracticalUi.Composite
{
  public class BindableBase<Tin, Tout> : BindableBase where Tout : new()
  {
    #region Fields

    private Tin attachedDataModel;

    #endregion Fields

    #region Methods

    public void SetDataModel(Tin data)
    {
      this.CopyPropertiesFrom(data);
      this.attachedDataModel = data;
      this.OnReadingDataModel(data);
    }

    public Tout WriteToDataModel()
    {
      return new Tout().CopyPropertiesFrom(this.attachedDataModel).CopyPropertiesFrom(this);
    }

    protected virtual void OnReadingDataModel(Tin data)
    {
    }

    #endregion Methods
  }
}