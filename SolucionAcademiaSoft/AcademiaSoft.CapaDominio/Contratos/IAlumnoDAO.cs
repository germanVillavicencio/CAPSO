using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaSoft.CapaDominio.Entidades;
namespace AcademiaSoft.CapaDominio.Contratos
{
    public interface IAlumnoDAO
    {
        Alumno buscarPorDni(string dni);
        void guardarAlumno(Alumno alumno);
    }
}
