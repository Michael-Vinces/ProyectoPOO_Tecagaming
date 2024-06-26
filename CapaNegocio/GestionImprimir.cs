﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio
{
    public class GestionImprimir
    {
        GestionEmpresa gempresa = new GestionEmpresa();
        GestionCliente gcliente = new GestionCliente();
        Empresa empresa = new Empresa();
        GestionProductoEscogido gpescogido = new GestionProductoEscogido();
        GestionTotalPago gtpago = new GestionTotalPago();

        public GestionImprimir()
        {

        }
        public string MostrarFactura(List<ProductoEscogido> lista, Cliente cliente)
        {
            string factura = "";
            var consulta = lista.OrderBy(p => p.miProducto.NombreProducto).Select(x => new { Producto = x.miProducto.NombreProducto, Precio = x.miProducto.ValorUnitario, cantidad = x.Cantidad });

            factura += "\t\t\t-----------------------------------------------------------------\n";
            factura += "\t\t\t|                      " + this.empresa.Nombre + " FACTURA                       |";
            factura += this.gempresa.MostrarEmpresa();
            factura += this.gcliente.MostrarCliente(cliente);
            int cont = 1;
            factura += "\n\t\t\t-----------------------------------------------------------------";
            factura += "\n\t\t\t|  N°       Producto             Valor Unitario        Cantidad |";
            factura += "\n\t\t\t-----------------------------------------------------------------";
            foreach (var item in consulta)
            {
                factura += "\n\t\t\t";
                factura += "|  " + cont + ". " + item.Producto + "\t     $" + item.Precio + "\t\t x" + item.cantidad;
                cont++;
            }
            factura += this.gtpago.MostrarTotalPago(gpescogido.MostrarSubtotal(lista));
            return factura;
        }
        public string MostrarProforma(List<ProductoEscogido> lista, Cliente cliente)
        {
            string proforma = "";
            var consulta = lista.OrderBy(p => p.miProducto.NombreProducto).Select(x => new { Producto = x.miProducto.NombreProducto, Precio = x.miProducto.ValorUnitario, cantidad = x.Cantidad });

            proforma += "\t\t\t-----------------------------------------------------------------\n";
            proforma += "\t\t\t|                      " + this.empresa.Nombre + " PROFORMA                       |";
            proforma += this.gempresa.MostrarEmpresa(); ;
            proforma += this.gcliente.MostrarCliente(cliente);
            int cont = 1;
            proforma += "\n\t\t\t-----------------------------------------------------------------";
            proforma += "\n\t\t\t|  N°       Producto             Valor Unitario        Cantidad  |";
            proforma += "\n\t\t\t-----------------------------------------------------------------";
            foreach (var item in consulta)
            {
                proforma += "\n\t\t\t";
                proforma += "|  " + cont + ". " + item.Producto + "\t     $" + item.Precio + "\t\t x" + item.cantidad;
                cont++;
            }
            proforma += this.gtpago.MostrarTotalPago(gpescogido.MostrarSubtotal(lista));
            return proforma;
        }
    }
}
