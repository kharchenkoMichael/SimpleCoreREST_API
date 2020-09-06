using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCoreREST_API.Data;

namespace SimpleCoreREST_API.Services
{
  public class Denormolizer
  {
    public List<DenormolizeRoute> Invoke(Route route)
    {
      return route.Stops
        .SelectMany(stop => stop.Objects.Select(obj => new DenormolizeRoute(route.RouteName, stop.StopName, obj.ObjectType, obj.ObjectName)))
        .ToList();
    }
  }
}
