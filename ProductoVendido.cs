using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class ProductoVendido
    {
        public int id { get; set; }
        public int idProducto { get; set; }
        public int Stock { get; set; }
        public int idVenta { get; set; }
        
        public ProductoVendido (int id , int idProducto , int Stock , int idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.Stock = Stock;
            this.idVenta = idVenta;
        }
    }
}
