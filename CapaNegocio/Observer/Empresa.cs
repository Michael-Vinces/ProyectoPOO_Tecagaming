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

        public List<IObserverSuscriptor> suscriptores = new List<IObserverSuscriptor>();

        CapaPersistenciaDatos.Modelos.Empresa Teca = new CapaPersistenciaDatos.Modelos.Empresa();

        public Empresa()
        {
            this.empresa = Teca;
        }
        public string AgregarSuscriptor(Cliente cliente)
        {
            Suscriptor subs = new Suscriptor();
            string mensaje = "";
            subs.clientee = cliente;
            suscriptores.Add(subs);
            mensaje+=$"{subs.clientee.Nombre.ToString()} con el celular de {subs.clientee.Contacto.ToString()} se ha suscrito a {empresa.Nombre}\n";
            return mensaje;
        }
        public string Notificar()
        {
            string mensaje = "";
            foreach (var suscriptor in suscriptores)
            {
                mensaje+=suscriptor.Actualizar();
            }
            return mensaje;
        }
        public string NuevoProducto(string nombreProducto)
        {
            string mensaje = "";
            this.nuevoProducto = nombreProducto;
            mensaje=this.Notificar();
            return mensaje;
        }
    }
}
