using reto_tecnico_backend_api.Entity;

namespace reto_tecnico_backend_api.Data
{
    public class DataUsuario : IDataUsuario
    {
        public List<UsuarioEntity> ListUsuarios()
        {
            return new List<UsuarioEntity>()
            {
                new UsuarioEntity() { Nombres  = "Juan Luis Guerra Meneses", Rol = "Usuario", Dni = "7879550" , Usuario = "test01"  ,Password = "test01"},
                new UsuarioEntity() { Nombres  = "Juan Luis Guerra Meneses", Rol = "Usuario", Dni = "7879551" , Usuario = "test02"  ,Password = "test02"},
                new UsuarioEntity() { Nombres  = "Juan Luis Guerra Meneses", Rol = "Usuario", Dni = "7879552" , Usuario = "test03"  ,Password = "test03"},
                new UsuarioEntity() { Nombres  = "Juan Luis Guerra Meneses", Rol = "Usuario", Dni = "7879553" , Usuario = "test04"  ,Password = "test04"},
                new UsuarioEntity() { Nombres  = "Juan Luis Guerra Meneses", Rol = "Usuario", Dni = "7879554" , Usuario = "test05"  ,Password = "test05"},
                new UsuarioEntity() { Nombres  = "Juan Luis Guerra Meneses", Rol = "Usuario", Dni = "7879555" , Usuario = "test06"  ,Password = "test06"},
                new UsuarioEntity() { Nombres  = "Juan Luis Guerra Meneses", Rol = "Usuario", Dni = "7879556" , Usuario = "test07"  ,Password = "test07"},
                new UsuarioEntity() { Nombres  = "Juan Luis Guerra Meneses", Rol = "Administrador", Dni = "7879557" , Usuario = "admin" , Password = "admin"},
            };
        }
    }
}
