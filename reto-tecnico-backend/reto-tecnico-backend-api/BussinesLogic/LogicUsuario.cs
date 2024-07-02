using reto_tecnico_backend_api.Data;
using reto_tecnico_backend_api.Entity;

namespace reto_tecnico_backend_api.BussinesLogic
{
    public class LogicUsuario : ILogicUsuario
    {
        private readonly IDataUsuario _idata;
        public LogicUsuario(IDataUsuario iData)
        {
            _idata = iData;
        }
        public (UsuarioEntity, List<UsuarioEntity>) LoginUsuario(string usuario, string password)
        {
            var listUsuarios = _idata.ListUsuarios();
            var listaRetornar = new List<UsuarioEntity>();

            var usuarioEntity = listUsuarios.FirstOrDefault(f => f.Usuario == usuario && f.Password == password);

            if (usuarioEntity == null)
                throw new Exception("El usuario con el que intenta iniciar sesión, no existe!");

            // validando el Tipo

            if (usuarioEntity.Rol == "Administrador")
                listaRetornar = listUsuarios.Where(w => w.Dni != usuarioEntity.Dni).ToList();


            return (usuarioEntity, listaRetornar);
        }
    }
}
