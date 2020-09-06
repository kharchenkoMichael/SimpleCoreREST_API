using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCoreREST_API.Data
{
  public class DenormolizeRoute
  {
    public DenormolizeRoute(string routeName, string stopName, string objectType, string objectName)
    {
      RouteName = routeName;
      StopName = stopName;
      ObjectType = objectType;
      ObjectName = objectName;
    }

    public string RouteName { get; }
    public string StopName { get; }

    public string ObjectType { get; }
    public string ObjectName { get; }

    public override bool Equals(object? obj)
    {
      if (!(obj is DenormolizeRoute denormolizeRoute))
        return false;

      return Equals(denormolizeRoute);
    }

    private bool Equals(DenormolizeRoute other)
    {
      return RouteName == other.RouteName && StopName == other.StopName && ObjectType == other.ObjectType && ObjectName == other.ObjectName;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(RouteName, StopName, ObjectType, ObjectName);
    }
  }
}
