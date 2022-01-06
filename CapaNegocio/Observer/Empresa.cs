using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio.Observer
{
    public class Empresa : ISujetoEmpresa
    {

        public CapaPersistenciaDatos.Modelos.Empresa empresa { get; set; }

        private string nuevoProducto = "";

        private List<IObserverSuscriptor> suscriptores = new List<IObserverSuscriptor>();


        CapaPersistenciaDatos.Modelos.Empresa Teca = new CapaPersistenciaDatos.Modelos.Empresa();

        public Empresa()
        {
            this.empresa = Teca;
        }


        //public string MostrarListaSubs()


        public void AgregarSuscriptor(Cliente cliente)
        {
            Suscriptor subs = new Suscriptor();
            subs.clientee = cliente;
            suscriptores.Add(subs);

            Console.WriteLine($"{subs.clientee.Nombre.ToString()} con el celular de {subs.clientee.Contacto.ToString()} se ha suscrito a {empresa.Nombre}");
        }

        public void EliminarSuscriptor(IObserverSuscriptor suscriptor)
        {
            suscriptores.Remove(suscriptor);
            Console.WriteLine($"{suscriptor.ToString()} ha eliminiado su suscripciÃ³n de {empresa.Nombre}");
        }

        public void Notificar()
        {
            foreach (var suscriptor in suscriptores)
            {
                suscriptor.Actualizar();

            }
        }


        public void NuevoProducto(string nombreProducto)
        {

            this.nuevoProducto = nombreProducto;
            this.Notificar();

        }


        public string UltimoProducto()
        {

            return this.nuevoProducto;

        }

    }
}
