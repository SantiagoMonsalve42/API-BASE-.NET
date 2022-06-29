using DTO.Transport.Producto;

namespace Bussiness.Interfaces
{
    public interface IProductoBusiness
    {
        Task<ICollection<ProductoGetDto>> get();
        Task<ProductoGetDto> get(int id);
        Task<ProductoCreateDto> put(ProductoCreateDto request, int id);
        Task<ProductoCreateDto> create(ProductoCreateDto request);
        Task<bool> delete(int id);
    }
}
