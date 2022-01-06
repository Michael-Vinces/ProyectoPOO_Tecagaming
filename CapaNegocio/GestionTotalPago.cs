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
        public GestionTotalPago()
        {

        }
        public string MostrarTotalPago(double subtotal)
        {
            this.totalpago.IVA = subtotal * 0.12;
            this.totalpago.Total = subtotal + this.totalpago.IVA;
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
