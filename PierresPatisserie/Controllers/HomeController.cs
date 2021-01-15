using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using PierresPatisserie.Models;

namespace PierresPatisserie.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresPatisserieContext _db;
    
    
    public HomeController(PierresPatisserieContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      ViewBag.Flavors =  _db.Flavors.OrderBy(f => f.FlavorType).ToList();
      ViewBag.Treats = _db.Treats.OrderBy(t => t.TreatName).ToList();
      return View();
    }
  }
}
