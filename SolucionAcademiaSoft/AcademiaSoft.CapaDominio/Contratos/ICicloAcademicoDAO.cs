using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaSoft.CapaDominio.Entidades;


namespace AcademiaSoft.CapaDominio.Contratos
{
    public interface ICicloAcademicoDAO
    {
        List<CicloAcademico> buscarCiclosAcademicos();
        List<Clase> obtenerClasesDeUnCiclo(string periodo);
    }
}
