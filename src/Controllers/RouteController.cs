using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SimpleCoreREST_API.Data;
using SimpleCoreREST_API.Services;

namespace SimpleCoreREST_API.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class RouteController : ControllerBase
  {
    private Denormolizer _denormolizer;

    public RouteController(Denormolizer denormolizer)
    {
      _denormolizer = denormolizer;
    }

    [HttpPost]
    public ActionResult Post(List<Route> routes)
    {
      return Ok(routes.SelectMany(route => _denormolizer.Invoke(route)).ToList());
    }
  }
}
