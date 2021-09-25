using ClothingStore.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothingStore.WemAdmin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Productos
        public ActionResult Index ()
         {

            var productosBL = new ProductosBL();
            var listaProductos = productosBL.obtenerProductos();

             return View(listaProductos);
           
         }
    }
}