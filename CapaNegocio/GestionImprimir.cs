using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio
{
    public class GestionImprimir
    {
        GestionEmpresa xd = new GestionEmpresa();
        GestionCliente xe = new GestionCliente();
        Empresa xs = new Empresa();
        GestionProductoEscogido xr = new GestionProductoEscogido();
        GestionTotalPago xc = new GestionTotalPago();
        public GestionImprimir()
        {

        }
        public string MostrarFactura(List<ProductoEscogido> lista, Cliente cliente)
        {
            string factura = "";
            factura += "\t\t\t-----------------------------------------------------------------\n";
            factura += "\t\t\t|                      " + this.xs.Nombre + " FACTURA                       |";
            factura += this.xd.MostrarEmpresa();
            factura += this.xe.MostrarCliente(cliente);
            int cont = 1;
            factura += "\n\t\t\t-----------------------------------------------------------------";
            factura += "\n\t\t\t|  N°       Producto             Valor Unitario        Cantidad |";
            factura += "\n\t\t\t-----------------------------------------------------------------";
            foreach (var item in lista)
            {
                factura += "\n\t\t\t";
                factura += "|  " + cont + ". " + item.miProducto.NombreProducto + "\t     $" + item.miProducto.ValorUnitario + "\t\t x" + item.Cantidad;
                cont++;
            }
            factura += this.xc.MostrarTotalPago(xr.MostrarSubtotal(lista));
            return factura;
        }
        public string MostrarProforma(List<ProductoEscogido> lista, Cliente cliente)
        {
            string proforma = "";
            proforma += "\t\t\t-----------------------------------------------------------------";
            proforma += "\t\t\t|                      " + this.xs.Nombre + " PROFORMA                       |";
            proforma += this.xd.MostrarEmpresa(); ;
            proforma += this.xe.MostrarCliente(cliente);
            int cont = 1;
            proforma += "\n\t\t\t-----------------------------------------------------------------";
            proforma += "\n\t\t\t|  N°       Producto             Valor Unitario        Cantidad  |";
            proforma += "\n\t\t\t-----------------------------------------------------------------";
            foreach (var item in lista)
            {
                proforma += "\n\t\t\t";
                proforma += "|  " + cont + ". " + item.miProducto.NombreProducto + "\t     $" + item.miProducto.ValorUnitario + "\t\t x" + item.Cantidad;
                cont++;
            }
            proforma += this.xc.MostrarTotalPago(xr.MostrarSubtotal(lista));
            return proforma;
        }
    }
}
