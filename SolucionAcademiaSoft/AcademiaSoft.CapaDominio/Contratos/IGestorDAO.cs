using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaSoft.CapaDominio.Entidades;


namespace AcademiaSoft.CapaDominio.Contratos
{
    public interface IGestorDAO
    {
        void abrirConexion();
        void cerrarConexion();
        void iniciarTransaccion();
        void terminarTransaccion();
        void cancelarTransaccion();
    }
}
