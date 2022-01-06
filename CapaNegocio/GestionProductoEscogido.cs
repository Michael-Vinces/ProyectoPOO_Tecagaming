using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio
{
    public class GestionProductoEscogido
    {
        ProductoEscogido total = new ProductoEscogido();
        public GestionProductoEscogido()
        {

        }
        public void EliminarProducto(int num, List<ProductoEscogido> ListaProductosEscogidos)
        {
            ProductoEscogido producto = new ProductoEscogido();

            for (int i = 1; i <= ListaProductosEscogidos.Count; i++)
            {
                if (i == num - 1)
                {
                    producto = ListaProductosEscogidos[i];
                    break;
                }
            }
            ListaProductosEscogidos.Remove(producto);
        }

        public ProductoEscogido EscogerProducto(int num, List<GestionProductos> inventario, List<ProductoEscogido> ListaProductosEscogidos)
        {
            Productos pr = new Productos();
            GestionProductos producto = new GestionProductos("Mouse Gaming color Blanco", 346);

            for (int i = 1; i <= inventario.Count; i++)
            {
                if (i == num - 1)
                {

                    producto = inventario[i];
                    break;
                }
            }
            ProductoEscogido productoEscogido = new ProductoEscogido();

            productoEscogido.miProducto = producto.es;
            productoEscogido.miProducto.NombreProducto = producto.es.NombreProducto;
            productoEscogido.miProducto.ValorUnitario = producto.es.ValorUnitario;

            ListaProductosEscogidos.Add(productoEscogido);

            return productoEscogido;
        }
        public void EscogerCantidad(int cantidad, ProductoEscogido productoEscogido)
        {

            productoEscogido.Cantidad = cantidad;

        }
        public string MostrarListaVenta(List<ProductoEscogido> ListaProdEscg)
        {
            string mensaje = "";
            int cont = 1;
            double precio = 0, cantidad = 0, subtotal = 0;
            mensaje += "\n\t\t--------------------------------------------------------------------------------";
            mensaje += "\n\t\t      N°        Producto                Valor Unitario        Cantidad";
            mensaje += "\n\t\t--------------------------------------------------------------------------------";
            for (int i = 0; i < ListaProdEscg.Count; i++)
            {
                mensaje += "\n\t\t      " + cont + ". " + ListaProdEscg[i].miProducto.NombreProducto + "\t     $" + ListaProdEscg[i].miProducto.ValorUnitario + "\t\t x" + ListaProdEscg[i].Cantidad;
                cont++;
                cantidad = ListaProdEscg[i].Cantidad;
                precio = ListaProdEscg[i].miProducto.ValorUnitario;
                subtotal = precio * cantidad;
                total.Subtotal += subtotal;
            }
            mensaje += "\n\t\t--------------------------------------------------------------------------------";
            mensaje += "\n\t\t SUBTOTAL: \t$" + total.Subtotal;
            mensaje += "\n\t\t--------------------------------------------------------------------------------";
            return mensaje;

        }
        public double MostrarSubtotal(List<ProductoEscogido> ListaProdEscg)
        {

            int cont = 1;
            double precio = 0, cantidad = 0, subtotal = 0;
            for (int i = 0; i < ListaProdEscg.Count; i++)
            {
                cont++;
                cantidad = ListaProdEscg[i].Cantidad;
                precio = ListaProdEscg[i].miProducto.ValorUnitario;
                subtotal = precio * cantidad;
                total.Subtotal += subtotal;
            }

            return total.Subtotal;
        }
    }
}
