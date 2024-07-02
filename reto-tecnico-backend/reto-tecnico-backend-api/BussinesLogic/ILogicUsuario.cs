using reto_tecnico_backend_api.Entity;

namespace reto_tecnico_backend_api.BussinesLogic
{
    public interface ILogicUsuario
    {
        public (UsuarioEntity, List<UsuarioEntity>) LoginUsuario(string usuario, string password);
    }
}
