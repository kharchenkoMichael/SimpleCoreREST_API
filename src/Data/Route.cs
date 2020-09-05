using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCoreREST_API.Data
{
  public class Route
  {
    public string RouteName { get; set; }

    public List<Stop> Stops { get; set; }
  }
}
