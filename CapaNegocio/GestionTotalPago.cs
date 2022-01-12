using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio
{
    public class GestionTotalPago
    {
        TotalPago totalpago = new TotalPago();

        //Expresion Lambda que calcula el iva, la cual recibe el parametro del subtotal y lo multiplica por su respectivo iva.
        // El parametro es de tipo double al igual que su salida
        Func<double, double> iva = (pagoparcial) => pagoparcial * 0.12;

        // Expresion lambda que calcula el total de la venta, que recibe los parametros del subtotal y su multiplicacion por el iva.
        // Ambos parametros son de tipo double al igual que su salida
        Func<double, double, double> total = (pagoparcial, pagoiva) => pagoparcial + pagoiva;
        public GestionTotalPago()
        {

        }
        public string MostrarTotalPago(double subtotal)
        {
            this.totalpago.IVA = iva(subtotal);
            this.totalpago.Total = total(subtotal, this.totalpago.IVA);
            string mensaje = "";
            mensaje += "\n\t\t\t-----------------------------------------------------------------";
            mensaje += "\n\t\t\t-----------------------------------------------------------------";
            mensaje += "\n\t\t\t| SubTotal  |  $" + subtotal;
            mensaje += "\n\t\t\t-----------------------------------------------------------------";
            mensaje += "\n\t\t\t| IVA 12%   |  $" + this.totalpago.IVA;
            mensaje += "\n\t\t\t-----------------------------------------------------------------";
            mensaje += "\n\t\t\t| Total     |  $" + this.totalpago.Total;
            mensaje += "\n\t\t\t-----------------------------------------------------------------";

            return mensaje;
        }
    }
}
