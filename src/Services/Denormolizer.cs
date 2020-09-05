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
        .SelectMany(stop => stop.Objects.Select(obj => new DenormolizeRoute
        {
          RouteName = route.RouteName,
          StopName = stop.StopName,
          ObjectType = obj.ObjectType,
          ObjectName = obj.ObjectName
        }))
        .ToList();
    }
  }
}
