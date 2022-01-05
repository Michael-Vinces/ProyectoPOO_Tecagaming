using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaDatos.Modelos
{
    // CLASE PARA EL CÁLCULO DEL PAGO DE LA COMPRA
    public class TotalPago : IImprimir
    {
        // PROPIEDADES DE LA CLASE TOTALPAGO

        // CÁLCULOS PARA EL PAGO FINAL
        public double Subtotal { get; set; }
        public double IVA { get; set; }
        public double Total { get; set; }

        // CONSTRUCTOR DE LA CLASE TOTALPAGO
        public TotalPago()
        {

        }
        // METODOS DE LA CLASE TOTALPAGO
        public string MostrarCliente()
        {
            throw new NotImplementedException();
        }

        public string MostrarTotalPago()
        {
            this.IVA = this.Subtotal * 0.12;
            this.Total = this.Subtotal + this.IVA;

            return "\t\t\t-----------------------------------------------------------------" +
                "\n\t\t\t| SubTotal  |  $" + this.Subtotal +
                "\n\t\t\t-----------------------------------------------------------------" +
                "\n\t\t\t| IVA 12%   |  $" + this.IVA +
                "\n\t\t\t-----------------------------------------------------------------" +
                "\n\t\t\t| Total     |  $" + this.Total +
                "\n\t\t\t-----------------------------------------------------------------";
        }
    }
}
