using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaDatos.Modelos
{
    //CLASE PARA EL INGRESO DE LOS DATOS DEL CLIENTE
    public class Cliente : Persona
    {
        // PROPIEDADES DE LA CLASE CLIENTE

        // INFORMACION PERSONAL DEL CLIENTE
       
        public string Contacto { get; set; }
        public string Domicilio { get; set; }

        // CONSTRUCTOR DE LA CLASE CLIENTE
        public Cliente()
        {

        }

       
    }
}
