using Microsoft.AspNetCore.Mvc;
using PierreTreats.Models;
using System.Linq;

namespace PierresTreats.Controllers
{
    public class HomeController : Controller
    {
      private readonly PierreTreatsContext _db;
      public HomeController(PierreTreatsContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.TreatsList = _db.Treats.OrderBy(m => m.Name).ToList();
        ViewBag.FlavorsList = _db.Flavors.OrderBy(m => m.Description).ToList();
        return View();
      }

    }
} 