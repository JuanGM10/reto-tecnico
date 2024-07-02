using reto_tecnico_backend_api.Entity;

namespace reto_tecnico_backend_api.Model
{
    public class Response
    {
        public UsuarioEntity Usuario { get; set; }
        public List<UsuarioEntity> Usuarios { get; set; }
        public string Token { get; set; }
    }
}
