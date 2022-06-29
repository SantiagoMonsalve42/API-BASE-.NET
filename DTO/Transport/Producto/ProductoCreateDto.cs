namespace DTO.Transport.Producto
{
    public class ProductoCreateDto
    {
        public decimal? Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal PrecioActual { get; set; }
        public decimal Stock { get; set; }
        public decimal IdProvedor { get; set; }
    }
}
