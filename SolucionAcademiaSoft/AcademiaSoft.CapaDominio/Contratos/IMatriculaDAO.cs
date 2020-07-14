using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaSoft.CapaDominio.Entidades;
namespace AcademiaSoft.CapaDominio.Contratos
{
    public interface IMatriculaDAO
    {
        void GuardarMatricula(Matricula matricula, string turno);
        List<Matricula> ObtenerMatriculasDeUnCiclo(string periodo);
    }
}
