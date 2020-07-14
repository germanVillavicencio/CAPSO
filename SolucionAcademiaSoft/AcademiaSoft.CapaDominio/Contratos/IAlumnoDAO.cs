using AcademiaSoft.CapaDominio.Entidades;
namespace AcademiaSoft.CapaDominio.Contratos
{
    public interface IAlumnoDAO
    {
        Alumno BuscarPorDni(string dni);
        void GuardarAlumno(Alumno alumno);
        bool EsValidoCorreo(string correo);
    }
}
