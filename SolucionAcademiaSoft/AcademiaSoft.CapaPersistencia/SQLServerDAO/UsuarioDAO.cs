﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaSoft.CapaDominio.Entidades;

namespace AcademiaSoft.CapaPersistencia.SQLServerDAO
{
    public class UsuarioDAO
    {
        private GestorSQL gestorSQL;

        public UsuarioDAO(GestorSQL gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

    }
}
