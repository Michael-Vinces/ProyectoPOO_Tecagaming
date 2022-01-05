using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaDatos.Modelos
{
    //CLASE PARA EL INGRESO DE LOS DATOS DEL CLIENTE
    public class Cliente : Persona, IImprimir
    {
        // PROPIEDADES DE LA CLASE CLIENTE

        // INFORMACION PERSONAL DEL CLIENTE
        public int Cedula { get; set; }
        public string Contacto { get; set; }
        public string Domicilio { get; set; }


        // CONSTRUCTOR DE LA CLASE CLIENTE
        public Cliente()
        {

        }

        // METODOS DE LA CLASE CLIENTE
        public string MostrarTotalPago()
        {
            throw new NotImplementedException();
        }

        public string MostrarCliente()
        {
            return "\t\t\t-----------------------------------------------------------------" +
                "\n\t\t\t| Nombre  \t\t|" + this.Nombre +
                "\n\t\t\t-----------------------------------------------------------------" +
                "\n\t\t\t| Cedula de Identidad   |" + this.Cedula + "\t\t\t\t|" +
                "\n\t\t\t-----------------------------------------------------------------" +
                "\n\t\t\t| Direccion  \t\t|" + this.Domicilio +
                "\n\t\t\t-----------------------------------------------------------------" +
                "\n\t\t\t| Contacto    \t\t|" + this.Contacto + "\t\t\t\t|" +
                "\n\t\t\t-----------------------------------------------------------------";
        }
    }
}
