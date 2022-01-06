using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaDatos.Modelos
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }

        public Empresa()
        {
            this.Nombre = "TECAGAMING";
            this.Direccion = "Calle 14 y Av 30 (Dentro de Plaza Forum)";
            this.Contacto = "2928205";
            this.Ciudad = "Manta, Manabi";
        }
    }
}
