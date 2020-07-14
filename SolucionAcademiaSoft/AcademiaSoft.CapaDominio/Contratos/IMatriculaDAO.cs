using AcademiaSoft.CapaDominio.Entidades;
using System.Collections.Generic;
namespace AcademiaSoft.CapaDominio.Contratos
{
    public interface IMatriculaDAO
    {
        void GuardarMatricula(Matricula matricula, string turno);
        List<Matricula> ObtenerMatriculasDeUnCiclo(string periodo);
    }
}
