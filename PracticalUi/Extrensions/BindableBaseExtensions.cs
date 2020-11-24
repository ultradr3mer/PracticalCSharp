using PracticalUi.Composite;

namespace PracticalUi.Extrensions
{
  public static class BindableBaseExtensions
  {
    #region Methods

    public static Tvm Create<Tvm, Tdata>(Tdata data) where Tvm : BindableBase<Tdata>, new()
    {
      var vm = new Tvm();
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