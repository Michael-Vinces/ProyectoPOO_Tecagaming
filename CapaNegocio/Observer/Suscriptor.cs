using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio.Observer
{
    // Paso 5. Se crea la clase suscriptor (Observador) y hereda de  IObserverSuscriptor
    public class Suscriptor : IObserverSuscriptor
    {
        // Paso 6. Propiedad de tipo Cliente 
        public Cliente clientee { get; set; }

        public Suscriptor()
        {
            
        }
        // Paso 7. Le damos funcionalidad al  metodo Actualizar 
        // Retorna un mensaje de una notificacion 
        public string Actualizar(List<Suscriptor> suscriptores)
        {
            string mensaje = "";
            // Ordena segun el abecedario los apellidos de los suscriptores y selecciona el nombre completo
            // con su respectivo numero telefonico 
            var consulta = suscriptores.OrderBy(p => p.clientee.Apellido).Select(x => new {
                nombres = x.clientee.Nombre,
                apellidos = x.clientee.Apellido,
                telefono = x.clientee.Contacto
            });  // [6] 
            foreach (var item in consulta)  // < ----
            {
                mensaje += $"\t\tSe ha notificado a {item.apellidos} {item.nombres} con el contacto {item.telefono}\n";  // [6] < ----
            }

            return mensaje;
        }
    }
}
