namespace AcademiaSoft.CapaDominio.Contratos
{
    public interface IGestorDAO
    {
        void AbrirConexion();
        void CerrarConexion();
        void IniciarTransaccion();
        void TerminarTransaccion();
        void CancelarTransaccion();
    }
}
