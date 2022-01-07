using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio.Observer
{
    // Paso 9.  Se crea la clase Empresa (Observable) y hereda de  ISujetoEmpresa
    public class Empresa : ISujetoEmpresa
    {
        // Paso 10. Propiedad de tipo Empresa que accede al nombre de la Empresa que se encuentra en CapaPersistenciaDatos.Modelos

        public CapaPersistenciaDatos.Modelos.Empresa empresa { get; set; }

        // Variable privada de tipo string 

        private string nuevoProducto = "";

        // Paso 11. Lista de  Suscriptores de tipo IObserverSuscriptor

        public List<IObserverSuscriptor> suscriptores = new List<IObserverSuscriptor>();

        // Paso 12. Instancia de la clase empresa 

        CapaPersistenciaDatos.Modelos.Empresa Teca = new CapaPersistenciaDatos.Modelos.Empresa();

        // Paso 13. Asignamos la empresa instanciada a la propiedad empresa en el constructor de la clase 
        public Empresa()
        {
            this.empresa = Teca;
        }

        // Paso 14. Le damos funcionalidad al metodo AgregarSuscriptor
        // Le pasamos un cliente, se crea una instacia de suscriptor y le asignamos el cliente 
        // Se agraga supcritor a la lista de suscriptores 
        // Retorna un mensaje que confirme que el usuario se suscribio a la empresa 
        public string AgregarSuscriptor(Cliente cliente)
        {
            Suscriptor subs = new Suscriptor();
            string mensaje = "";
            subs.clientee = cliente;
            suscriptores.Add(subs);
            mensaje+=$"{subs.clientee.Nombre.ToString()} con el celular de {subs.clientee.Contacto.ToString()} se ha suscrito a {empresa.Nombre}\n";
            return mensaje;
        }

        // Paso 15. Le damos funcionalidad al metodo Notificar 
        // Recorre la lista de suscriptores y en cada integracion llama al metodo actualizar
        // Retorna un mensaje que muestran que se han notificado a todos los clientes de la lista Suscriptores
        public string Notificar()
        {
            string mensaje = "";
            foreach (var suscriptor in suscriptores)
            {
                mensaje+=suscriptor.Actualizar();
            }
            return mensaje;
        }

        // Paso 16. Creamos el metodo nuevo producto 
        // Pide por parametro un string con el nombre del producto 
        // Se llama al metodo Notificar 
        // Retorna todas las notificaciones disponibles en un mensaje 
        public string NuevoProducto(string nombreProducto)
        {
            string mensaje = "";
            this.nuevoProducto = nombreProducto;
            mensaje=this.Notificar();
            return mensaje;
        }
    }
}
