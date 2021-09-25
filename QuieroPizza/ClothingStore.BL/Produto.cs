using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.BL
{
   public  class producto
    {
        public int id { get; set; }
        public string  Descripcion { get; set; }
        public double Precio { get; set; }
        public int Id { get; internal set; }
    }
}
