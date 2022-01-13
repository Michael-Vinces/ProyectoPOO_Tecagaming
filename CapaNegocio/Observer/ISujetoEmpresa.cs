using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio.Observer
{
    // Paso 1. Se crea la interfaz del sujeto u observado 
    public interface ISujetoEmpresa
    {
        // Paso 2. Se crea el Metodo Notificar
        string Notificar(List<Suscriptor> suscriptores);
    }
}
