using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaDatos.Modelos
{
    //CLASE PARA INICIAR SESIÓN EN EL PROGRAMA
    public class Usuario : Persona
    {
        // PROPIEDADES DE LA CLASE USUARIO

        public string Username { get; set; }
        public string Password { get; set; }

        // CONSTRUCTOR DE LA CLASE USUARIO
        public Usuario()
        {

        }

        //METODOS DE LA CLASE USUARIO
    }
}
