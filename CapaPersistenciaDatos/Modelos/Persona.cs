using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaDatos.Modelos
{
    // CLASE PARA EL INGRESO DE NOMBRE Y ES USADA COMO HERENCIA EN LA CLASE USUARIO Y CLIENTE
    public class Persona
    {
        // PROPIEDADES DE LA CLASE PERSONA

        public string Nombre { get; set; }
        public int Cedula { get; set; }

        // CONSTRUCTOR DE LA CLASE PERSONA
        public Persona()
        {

        }
        // METODOS DE LA CLASE PERSONA
    }
}
