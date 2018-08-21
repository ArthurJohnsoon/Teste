using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Presentation.Areas.AreaRestrita.Models;

namespace Projeto.Presentation.Areas.AreaRestrita.Controllers
{
    public class PrincipalController : Controller
    {
        [Authorize]
        // GET: AreaRestrita/Principal
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
      public ActionResult Index(UsuarioCadastroViewModel model)
        {
            return View();
        }
    }
}