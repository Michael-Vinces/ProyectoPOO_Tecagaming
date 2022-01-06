using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaDatos.Modelos
{
    public class ProductoEscogido
    {

        public Productos miProducto { get; set; }
        public int Cantidad { get; set; }
        public double Subtotal { get; set; }

        public ProductoEscogido()
        {

        }

    }
}
