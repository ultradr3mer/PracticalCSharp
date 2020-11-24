using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.DataModel
{
  public class ContainerModel
  {
    public List<ScriptModel> Scripts { get; set; } = new List<ScriptModel>();

    public List<ReferenceModel> References { get; set; } = new List<ReferenceModel>();
  }
}
