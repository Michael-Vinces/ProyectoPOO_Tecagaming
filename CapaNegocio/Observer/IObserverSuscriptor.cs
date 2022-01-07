using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio.Observer
{
    // Paso 4. Se crea la interfaz del observador 
    public interface IObserverSuscriptor
    { 
        // Paso 5. Se crea el Metodo Actualizar
        string Actualizar();
    }
}
