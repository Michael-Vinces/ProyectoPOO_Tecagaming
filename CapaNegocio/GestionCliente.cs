using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio
{
    public class GestionCliente
    {
        public string MostrarCliente(Cliente cliente)
        {
            string datoscliente = "";
            datoscliente += "\n\t\t\t-----------------------------------------------------------------";
            datoscliente += "\n\t\t\t| Nombre  \t\t|" + cliente.Nombre + " " + cliente.Apellido;
            datoscliente += "\n\t\t\t-----------------------------------------------------------------";
            datoscliente += "\n\t\t\t| Cedula de Identidad   |" + cliente.Cedula + "\t\t\t\t|";
            datoscliente += "\n\t\t\t-----------------------------------------------------------------";
            datoscliente += "\n\t\t\t| Direccion  \t\t|" + cliente.Domicilio + "";
            datoscliente += "\n\t\t\t-----------------------------------------------------------------";
            datoscliente += "\n\t\t\t| Contacto    \t\t|" + cliente.Contacto + "\t\t\t\t|";
            datoscliente += "\n\t\t\t-----------------------------------------------------------------";
            return datoscliente;
        }
    }
}
