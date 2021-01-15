using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using PierresPatisserie.Models;

namespace PierresPatisserie.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierresPatisserieContext _db;

    public FlavorsController(PierresPatisserieContext db)
    {
      _db = db;
    }
  }
}