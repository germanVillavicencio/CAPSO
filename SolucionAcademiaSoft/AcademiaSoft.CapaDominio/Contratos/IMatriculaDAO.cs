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
        void guardarMatricula(Matricula matricula, string turno);
        List<Matricula> listarMatriculasActuales();
        List<Matricula> obtenerMatriculasDeUnCiclo(string periodo);
    }
}
