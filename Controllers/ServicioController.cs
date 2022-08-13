using CRUD_MVC_aspNet_framework_4.Models;
using CRUD_MVC_aspNet_framework_4.Models.entidadb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_MVC_aspNet_framework_4.Controllers
{
    public class ServicioController : Controller
    {
        // GET: Servicio
        public ActionResult Index()
        {
            List<EntidadServicio> listaServicio;
            using(crudaspnetframewordEntities1 db =new crudaspnetframewordEntities1())
            {
                listaServicio = (from d in db.Servicio
                                 select new EntidadServicio
                                 {
                                     id = d.id,
                                     nombre = d.nombre,
                                     direccion = d.direccion
                                 }).ToList();
            }
            return View(listaServicio);
        }
    }
}