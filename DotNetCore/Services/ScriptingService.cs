namespace DotNetCore.Models
{
  using System;
  using System.Linq;
  using System.Reflection;
  using System.Threading.Tasks;
  using Microsoft.CodeAnalysis.CSharp.Scripting;
  using Microsoft.CodeAnalysis.Scripting;

  public class ScriptingService
  {
    #region Fields

    private ScriptOptions options;

    private ScriptState<object> state;

    #endregion

    #region Constructors

    public ScriptingService()
    {
      Assembly references = Assembly.GetAssembly(typeof(Enumerable));
      this.options = ScriptOptions.Default.AddReferences(references);
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

      return (this.state.ReturnValue ?? "null").ToString();
    }

    #endregion
  }
}