namespace reto_tecnico_backend_api.Entity
{
    public class UsuarioEntity
    {
        public string Id { get => new Guid().ToString(); }
        public string Dni { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Rol { get; set; }
    }
}
