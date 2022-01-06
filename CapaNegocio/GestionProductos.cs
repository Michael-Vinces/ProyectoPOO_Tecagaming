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
        Productos xd = new Productos();
        public Productos es { get; set; }
        public GestionProductos(string nombre, double precio)
        {
            this.xd.NombreProducto = nombre;
            this.xd.ValorUnitario = precio;
        }

        public string MostrarInventario(List<GestionProductos> Lista)
        {
            string mensaje = "";
            int cont = 1;
            mensaje += "\t\tN°         Producto                 Valor Unitario\n";
            for (int i = 0; i < Lista.Count; i++)
            {
                mensaje += "\t\t" + cont + ". " + Lista[i].xd.NombreProducto + "\t\t$" + Lista[i].xd.ValorUnitario + "\n";
                cont++;
            }
            return mensaje;
        }
        public void EliminarProductoinventario(int num, List<GestionProductos> Listainventario)
        {
            GestionProductos producto = new GestionProductos("", 0);

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