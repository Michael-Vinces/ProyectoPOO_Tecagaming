﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos.Modelos;

namespace CapaNegocio.Observer
{
    public interface ISujetoEmpresa
    {
        string AgregarSuscriptor(Cliente cliente);
        string Notificar();
    }
}
