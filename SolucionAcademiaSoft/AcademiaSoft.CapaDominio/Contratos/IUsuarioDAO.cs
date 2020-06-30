using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaSoft.CapaDominio.Entidades;

namespace AcademiaSoft.CapaDominio.Contratos
{
    public interface IUsuarioDAO
    {
        Usuario buscarUsuario(string nickname);
    }
}