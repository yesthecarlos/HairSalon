using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using EauClaire.Models;


namespace EauClaire.Controllers
{
  public class ClientsController: Controller 
  {
    private readonly EauClaireContext _db;

    public ClientsController(EauClaireContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(client => client.Stylist).ToList();
      return View(model);
    }
  }
}