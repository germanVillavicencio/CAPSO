using AcademiaSoft.CapaDominio.Entidades;
using System.Collections.Generic;


namespace AcademiaSoft.CapaDominio.Contratos
{
    public interface ICicloAcademicoDAO
    {
        List<CicloAcademico> BuscarCiclosAcademicos();
        List<Clase> ObtenerClasesDeUnCiclo(string periodo);
    }
}
