using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio
{
    public class GestionProductos
    {

        public GestionProductos()
        {
        }

        public string MostrarInventarioOrdenado(List<Productos> Lista)
        {
            string mensaje = "";
            int cont = 0;
            // Ordena segun el abecedario los productos del inventario y selecciona su nombre y precio segun el orden que le corresponde.
            var consulta = Lista.OrderBy(p => p.NombreProducto).Select(x => new { Producto = x.NombreProducto, Precio = x.ValorUnitario }); //[5] 
            mensaje += "\t\tN°         Producto                 Valor Unitario\n";

            foreach (var item in consulta) // <----
            {
                cont++;
                mensaje += "\t\t" + cont + ". " + item.Producto + "\t\t$" + item.Precio +"\n"; //[5] <----
            }
            return mensaje;
        }
        public string MostrarInventario(List<Productos> Lista)
        {
            string mensaje = "";
            int cont = 0;
            mensaje += "\t\tN°         Producto                 Valor Unitario\n";
            for (int i = 0; i < Lista.Count; i++)
            {
                cont++;
                mensaje += "\t\t" + cont + ". " + Lista[i].NombreProducto + "\t\t$" + Lista[i].ValorUnitario + "\n";
            }
            return mensaje;
        }
        public void EliminarProductoinventario(int num, List<Productos> Listainventario)
        {
            Productos producto = new Productos();
            
            for (int i = 1; i <= Listainventario.Count; i++)
            {
                if (i == num - 1)
                {
                    producto = Listainventario[i];
                    break;
                }
            }
            Listainventario.Remove(producto);
        }
    }
}