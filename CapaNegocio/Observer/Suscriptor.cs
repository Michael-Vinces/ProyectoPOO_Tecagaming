using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio.Observer
{
    public class Suscriptor : IObserverSuscriptor
    {
        public Cliente clientee { get; set; }

        public Suscriptor()
        {
            
        }

        public string Actualizar()
        {
            string mensaje = "";
            mensaje+=$"\t\tSe ha notificado a {clientee.Nombre} al contacto {clientee.Contacto}\n";
            return mensaje;
        }
    }
}
