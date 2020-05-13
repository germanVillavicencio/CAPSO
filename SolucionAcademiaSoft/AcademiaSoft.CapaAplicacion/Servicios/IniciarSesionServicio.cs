using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaPersistencia.SQLServerDAO;

namespace AcademiaSoft.CapaAplicacion.Servicios
{
    public class IniciarSesionServicio
    {
        private GestorSQL gestorSQL;

        public IniciarSesionServicio()
        {
            gestorSQL = new GestorSQL();
        }


    }
}
