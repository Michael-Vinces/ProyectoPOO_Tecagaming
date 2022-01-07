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

        public string MostrarInventario(List<Productos> Lista)
        {
            string mensaje = "";
            int cont = 1;
            mensaje += "\t\tN°         Producto                 Valor Unitario\n";
            for (int i = 0; i < Lista.Count; i++)
            {
                mensaje += "\t\t" + cont + ". " + Lista[i].NombreProducto + "\t\t$" + Lista[i].ValorUnitario + "\n";
                cont++;
            }
            return mensaje;
        }
        public void EliminarProductoinventario(int num, List<Productos> Listainventario)
        {
            Productos producto = new Productos("",0);

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