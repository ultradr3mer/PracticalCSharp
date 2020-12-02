namespace PracticalUi.Services
{
  using Microsoft.CodeAnalysis.CSharp.Scripting;
  using Microsoft.CodeAnalysis.Scripting;
  using System.Linq;
  using System.Reflection;
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

    /// <summary>
    /// Executes the provided code fragment.
    /// </summary>
    /// <typeparam name="TResult">The type of the result of the code fragment.</typeparam>
    /// <param name="code">The C# code fragment.</param>
    /// <returns>The value the code returned, if any.</returns>
    internal async Task<TResult> Run<TResult>(string code)
    {
      ScriptState<TResult> newState;
      if (this.state == null)
      {
        newState = await CSharpScript.RunAsync<TResult>(code, this.options);
      }
      else
      {
        newState = await this.state.ContinueWithAsync<TResult>(code, this.options);
      }

      return newState.ReturnValue;
    }

    #endregion Methods
  }
}