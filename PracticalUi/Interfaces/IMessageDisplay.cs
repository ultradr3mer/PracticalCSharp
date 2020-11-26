using System.Threading.Tasks;

namespace PracticalUi.Interfaces
{
  public interface IMessageDisplay
  {
    #region Methods

    Task ShowMessageAsync(string title, string message);

    #endregion Methods
  }
}