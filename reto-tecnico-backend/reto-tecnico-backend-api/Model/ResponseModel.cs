namespace reto_tecnico_backend_api.Model
{
    public class ResponseModel<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
