using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.BL
{
    public class ProductosBL
    {
        Contexto _contexto;
        public ProductosBL()
        {
            _contexto = new Contexto();
        }
        public List<producto> ObtenerProductos()
        {

            return _contexto.Productos.ToList();
        }


    }
}
