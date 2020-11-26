namespace PracticalUi.Services
{
  using Microsoft.CodeAnalysis.CSharp.Scripting;
  using Microsoft.CodeAnalysis.Scripting;
  using System.Linq;
  using System.Reflection;
  using System.Text;
  using System.Threading.Tasks;

  /// <summary>
  /// The <see cref="ScriptingService"/> class is a service that provices C# roslyn scripting functionality.
  /// </summary>
  public class ScriptingService
  {
    #region Fields

    private readonly ScriptOptions options;
    private ScriptState<object> state;

    #endregion Fields

    #region Constructors

    /// <summary>
    /// Creates a new instance of the <see cref="ScriptingService"/> class.
    /// </summary>
    public ScriptingService()
    {
      this.options = ScriptOptions.Default.AddReferences(Assembly.GetAssembly(typeof(Enumerable))).AddImports("System", "System.Text", "System.Linq");
    }

    #endregion Constructors

    #region Methods

    /// <summary>
    /// Executes the provided code fragment.
    /// </summary>
    /// <param name="code">The C# code fragment.</param>
    /// <returns>The value the code returned, if any.</returns>
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

      object result = this.state.ReturnValue;
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

    #endregion Methods
  }
}