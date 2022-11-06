using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class Producto
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public float Costo { get; set; }
        public float PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string idUsuario { get; set; }

        public Producto (int id, string Descripcion, float Costo, float PrecioVenta, int Stock, string idUsuario)
        {
            this.id = id;
            this.Descripcion = Descripcion;
            this.Costo = Costo;
            this.PrecioVenta = PrecioVenta;
            this.Stock = Stock;
            this.idUsuario = idUsuario;
        }
    }
}
