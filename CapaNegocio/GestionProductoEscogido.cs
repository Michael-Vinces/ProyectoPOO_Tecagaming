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
         
        //Expresion Lambda que calcula el subtotal de los productos, la cual recibes los parametros del valor
        //unitario y la cantidad del mismo las cuales se multiplican.
        // Los parametros recibidos son de dos tipos double e int y su salida es de tipo double.

        Func<double, int, double> subtotal = (valorUnitario, cantidad) => valorUnitario * cantidad; //[1]
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

        public ProductoEscogido EscogerProducto(int num, List<Productos> inventario, List<ProductoEscogido> ListaProductosEscogidos)
        {
            
            Productos producto = new Productos();

            for (int i = 0; i <= inventario.Count; i++)
            {
                if (i == num-1)
                {

                    producto = inventario[i];
                    break;
                }
            }
            ProductoEscogido productoEscogido = new ProductoEscogido();
            
            productoEscogido.miProducto = producto;
            productoEscogido.miProducto.NombreProducto = producto.NombreProducto;
            productoEscogido.miProducto.ValorUnitario = producto.ValorUnitario;

            ListaProductosEscogidos.Add(productoEscogido);

            return productoEscogido;
        }
        public void EscogerCantidad(int cantidad, ProductoEscogido productoEscogido)
        {

            productoEscogido.Cantidad = cantidad;

        }
        public string MostrarVenta(List<ProductoEscogido> ListaProdEscg)
        {
            string mensaje = "";
            int cont = 0;
            mensaje += "\n\t\t--------------------------------------------------------------------------------";
            mensaje += "\n\t\t      N°        Producto                Valor Unitario        Cantidad";
            mensaje += "\n\t\t--------------------------------------------------------------------------------";
            for (int i = 0; i < ListaProdEscg.Count; i++)
            {
                cont++;
                mensaje += "\n\t\t      " + cont + ". " + ListaProdEscg[i].miProducto.NombreProducto + "\t     $" + ListaProdEscg[i].miProducto.ValorUnitario + "\t\t x" + ListaProdEscg[i].Cantidad;
            }
            return mensaje;

        }
        public string MostrarVentaOrdenada(List<ProductoEscogido> ListaProdEscg) 
        {
            string mensaje = "";
            int cont = 0;
            // Ordena segun el abecedario los productos de la venta y selecciona su nombre, precio y cantidad segun el orden que le corresponde.
            var consulta = ListaProdEscg.OrderBy(p => p.miProducto.NombreProducto).Select(x => new { Producto = x.miProducto.NombreProducto, 
                Precio = x.miProducto.ValorUnitario, cantidad=x.Cantidad}); //[4]
            total.Subtotal = 0;
            mensaje += "\n\t\t--------------------------------------------------------------------------------";
            mensaje += "\n\t\t      N°        Producto                Valor Unitario        Cantidad";
            mensaje += "\n\t\t--------------------------------------------------------------------------------";
            foreach (var item in consulta) // <----
            {
                cont++;
                mensaje += "\n\t\t      " + cont + ". " + item.Producto + "\t     $" + item.Precio + "\t\t x" + item.cantidad; //[4] <----
                total.Subtotal += subtotal(item.Precio, item.cantidad); //[1] <----
            }
            mensaje += "\n\t\t--------------------------------------------------------------------------------";
            mensaje += "\n\t\t SUBTOTAL: \t$" + total.Subtotal;
            mensaje += "\n\t\t--------------------------------------------------------------------------------";
            return mensaje;
        }
        public double MostrarSubtotal(List<ProductoEscogido> ListaProdEscg)
        {

            int cont = 1;
            total.Subtotal = 0;
            for (int i = 0; i < ListaProdEscg.Count; i++)
            {
                cont++;
                total.Subtotal += subtotal(ListaProdEscg[i].miProducto.ValorUnitario, ListaProdEscg[i].Cantidad);
            }

            return total.Subtotal;
        }
    }
}
