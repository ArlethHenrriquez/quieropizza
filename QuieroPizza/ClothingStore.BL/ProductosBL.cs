using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.BL
{
    public class ProductosBL
    {
       public List<producto> ObtenerProductos()
        {

            var producto1 = new producto();
            producto1.Id = 1;
            producto1.Descripcion = "Chaleco Amarillo Brillante ";
            producto1.Precio = 200;


            var producto2 = new producto();
            producto2.Id = 2;
            producto2.Descripcion = "Top de Popelina";
            producto2.Precio = 250;

            var producto3 = new producto();
            producto3.Id = 3;
            producto3.Descripcion = "Pantalon Acampanado  ";
            producto3.Precio = 180;


            var listadeProductos = new List<producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
                
                return listadeProductos;
        }

        public object obtenerProductos()
        {
            throw new NotImplementedException();
        }
    }
}
