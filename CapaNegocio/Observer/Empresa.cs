using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio.Observer
{
    // Paso 8.  Se crea la clase Empresa (Observable) y hereda de  ISujetoEmpresa
    public class Empresa : ISujetoEmpresa
    {
        // Variable privada de tipo string 

        private string nuevoProducto = "";

        public Empresa()
        {
            
        }


        // Paso 9. Le damos funcionalidad al metodo Notificar 
        // Recorre la lista de suscriptores y en cada integracion llama al metodo actualizar
        // Retorna un mensaje que muestran que se han notificado a todos los clientes de la lista Suscriptores
        public string Notificar(List<Suscriptor> suscriptores)
        {
            string mensaje = "";
            foreach (var suscriptor in suscriptores)
            {
                mensaje += suscriptor.Actualizar(suscriptores);
                break;
            }
            return mensaje;
        }

        // Paso 10. Creamos el metodo nuevo producto 
        // Pide por parametro un string con el nombre del producto 
        // Se llama al metodo Notificar 
        // Retorna todas las notificaciones disponibles en un mensaje 
        public string NuevoProducto(string nombreProducto, List<Suscriptor> suscriptores)
        {
            string mensaje = "";
            this.nuevoProducto = nombreProducto;
            mensaje=this.Notificar(suscriptores);
            return mensaje;
        }
    }
}
