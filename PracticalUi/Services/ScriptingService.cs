namespace PracticalUi.Services
{
  using Microsoft.CodeAnalysis.CSharp.Scripting;
  using Microsoft.CodeAnalysis.Scripting;
  using System;
  using System.Linq;
  using System.Reflection;
  using System.Threading.Tasks;

  public class ScriptingService
  {
    #region Fields

    private ScriptOptions options;
    private ScriptState<object> state;

    #endregion

    #region Constructors

    public ScriptingService()
    {
      this.options = ScriptOptions.Default.AddReferences(Assembly.GetAssembly(typeof(Enumerable))).AddImports("System");
    }
    
    #endregion

    #region Methods

    public async Task<string> Run(string code)
    {
      if (this.state == null)
      {
        this.state = await CSharpScript.RunAsync(code, this.options);
      }
      else
      {
        this.state = await this.state.ContinueWithAsync(code, this.options);
      }

      var result = this.state.ReturnValue;
      if (result == null)
      {
        return "null";
      }
      else if (result is string)
      {
        return $"\"{result}\"";
      }

      return result.ToString();
    }

    #endregion
  }
}