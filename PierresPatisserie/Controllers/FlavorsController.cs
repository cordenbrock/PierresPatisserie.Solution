using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using PierresPatisserie.Models;

namespace PierresPatisserie.Controllers
{
  public class GConsolesController : Controller
  {
    private readonly PierresPatisserieContext _db;

    public GConsolesController(PierresPatisserieContext db)
    {
      _db = db;
    }
  }
}