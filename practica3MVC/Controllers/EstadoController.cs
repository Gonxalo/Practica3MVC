using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practica3MVC.Models;

namespace practica3MVC.Controllers
{
    public class EstadoController : Controller
    {
        //
        // GET: /Estado/
        public ActionResult Index()
        {
            Contexto conexion = new Contexto();
            //creamos la lista
            List<Municipio> municipio = conexion.Municipio.ToList();
            return View();
        }

        public ActionResult Alta()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Alta(Municipio munipicio)
        {
            Contexto conexion = new Contexto();

            conexion.Municipio.Add(munipicio);
            conexion.SaveChanges();

            return RedirectToAction("Index");
        }
	}
}