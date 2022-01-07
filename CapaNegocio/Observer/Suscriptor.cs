using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio.Observer
{
    // Paso 6. Se crea la clase suscriptor (Observador) y hereda de  IObserverSuscriptor
    public class Suscriptor : IObserverSuscriptor
    {
        // Paso 7. Propiedad de tipo Cliente 
        public Cliente clientee { get; set; }

        public Suscriptor()
        {
            
        }
        // Paso 8. Le damos funcionalidad al  metodo Actualizar 
        // Retorna un mensaje de una notificacion 
        public string Actualizar()
        {
            string mensaje = "";
            mensaje+=$"\t\tSe ha notificado a {clientee.Nombre} al contacto {clientee.Contacto}\n";
            return mensaje;
        }
    }
}
