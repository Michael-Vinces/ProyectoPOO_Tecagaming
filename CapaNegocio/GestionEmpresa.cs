using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio
{
    public class GestionEmpresa
    {
        Empresa empresa = new Empresa();
        public DateTime fechaEmision = DateTime.Now;
        public string MostrarEmpresa()
        {
            string datosempresa = "";
            datosempresa += "\n\t\t\t-----------------------------------------------------------------";
            datosempresa += "\n\t\t\t-----------------------------------------------------------------";
            datosempresa += "\n\t\t\t| Dirección        |  " + empresa.Direccion + "  |";
            datosempresa += "\n\t\t\t| Contacto         |  " + empresa.Contacto + "                                   |";
            datosempresa += "\n\t\t\t| Ciudad           |  " + empresa.Ciudad + "                             |";
            datosempresa += "\n\t\t\t| Fecha de Emisión |  " + fechaEmision + "                       |";
            datosempresa += "\n\t\t\t-----------------------------------------------------------------";
            return datosempresa;
        }
    }
}
