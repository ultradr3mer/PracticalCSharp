namespace DotNetCore.Services
{
  using System.IO;
  using DataModel;
  using Newtonsoft.Json;

  public class DataPersistingService
  {
    #region Fields

    public const string FileName = "notebook.json";

    #endregion

    #region Methods

    public ContainerModel Load()
    {
      if (!File.Exists(DataPersistingService.FileName))
      {
        return new ContainerModel();
      }

      var fileContent = File.ReadAllText(DataPersistingService.FileName);
      var container = JsonConvert.DeserializeObject<ContainerModel>(fileContent);
      return container;
    }

    public void Save(ContainerModel container)
    {
      var fileContent = JsonConvert.SerializeObject(container);
      File.WriteAllText(DataPersistingService.FileName, fileContent);
    }

    #endregion
  }
}