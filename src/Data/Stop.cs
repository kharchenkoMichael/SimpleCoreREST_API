using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCoreREST_API.Data
{
  public class Stop
  {
    public string StopName { get; set; }

    public List<Object> Objects { get; set; }
  }
}
