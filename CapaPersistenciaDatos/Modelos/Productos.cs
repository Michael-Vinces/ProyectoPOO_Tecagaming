using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaDatos.Modelos
{
    // CLASE PARA EL CONTROL DE PRODUCTOS 
    public class Productos
    {
        // PROPIEDADES DE LA CLASE PRODUCTOS

        public string NombreProducto { get; set; }
        public double ValorUnitario { get; set; }
        public int Cantidad { get; set; }
       
        // PROPIEDADES PARA AGREGAR UN PRODUCTO
        public string NuevoProducto { get; set; }
        public double NuevoPrecio { get; set; }

        // PROPIEDADES PARA ELIMINAR UN PRODUCTO
        public int EliminarCantidad { get; set; }
      

        // CONSTRUCTOR DE LA CLASE PRODUCTOS
        public Productos(/*string nombre, double precio*/)
        {
            /*this.NombreProducto = nombre;
            this.ValorUnitario = precio;*/
        }

    }
}
