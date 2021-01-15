using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using PierresPatisserie.Models;

namespace PierresPatisserie.Controllers
{
  [Authorize]
  public class GamesController : Controller
  {
    private readonly PierresPatisserieContext _db;
    public TreatsController(PierresPatisserieContext db)
    {
      _db = db;
    }
  }
}