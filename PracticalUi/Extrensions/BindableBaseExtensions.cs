using PracticalUi.Composite;
using Prism.Mvvm;

namespace PracticalUi.Extrensions
{
  /// <summary>
  /// The <see cref="BindableBaseExtensions"/> class provides extension functions for the <see cref="BindableBase"/>
  /// </summary>
  public static class BindableBaseExtensions
  {
    #region Methods

    public static Tvm Create<Tvm, Tdata>(Tdata data) where Tvm : BindableBase<Tdata>, new()
    {
      Tvm vm = new Tvm();
      vm.SetDataModel(data);
      return vm;
    }

    public static Tvm GetWithDataModel<Tvm, Tdata>(this Tvm value, Tdata data) where Tvm : BindableBase<Tdata>
    {
      value.SetDataModel(data);
      return value;
    }

    #endregion Methods
  }
}