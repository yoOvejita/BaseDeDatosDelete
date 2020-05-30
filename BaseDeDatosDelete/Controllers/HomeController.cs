using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseDeDatosDelete.Controllers
{
    public class HomeController : Controller
    {
        private Models.EjemploASPNETEntities db = new Models.EjemploASPNETEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult EjemploDelete()
        {//La vista general donde se muestra la lista de productos
            ViewBag.productos = db.Producto.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)//La vista para eliminar un registro mediante su id
        {
            var producto = db.Producto.Find(id);//Encuentra el producto a ser eliminado
            db.Producto.Remove(producto);//Elimina el producto 
            db.SaveChanges();//guarda los cambios en la base de datos
            return RedirectToAction("EjemploDelete");
            
        }
    }
}