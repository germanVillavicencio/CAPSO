using AcademiaSoft.CapaDominio.Entidades;

namespace AcademiaSoft.CapaDominio.Contratos
{
    public interface IUsuarioDAO
    {
        Usuario BuscarUsuario(string nickname);
    }
}