using MadrigalDev_BL.Implementation;
using MadrigalDev_Model.EmpresaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MadrigalDev.Controllers
{
    public class EmpresaController : Controller
    {
        public EmpresaController()
        {
            
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<ActionResult> Add(EmpresaModel model)
        {
            var empresaB = new EmpresaBL();
            var res = empresaB.AddEmpresa(model);
            return View("Index");
        }
    }
}