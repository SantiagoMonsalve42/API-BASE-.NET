using Bussiness.Interfaces;
using Data.Interfaces;
using DTO.Transport.Producto;

namespace Bussiness.Implementations
{
    public class ProductoBusiness : IProductoBusiness
    {
        private readonly IProductoData Data;
        public ProductoBusiness(IProductoData repo)
        {
            Data = repo ?? throw new ArgumentNullException(nameof(repo));
        }
        public async Task<ProductoCreateDto> create(ProductoCreateDto request)
        {
            return await Data.create(request);
        }

        public async Task<bool> delete(int id)
        {
            return await Data.delete(id);
        }

        public async Task<ICollection<ProductoGetDto>> get()
        {
            return await Data.get();
        }

        public async Task<ProductoGetDto> get(int id)
        {
            return await Data.get(id);
        }

        public async Task<ProductoCreateDto> put(ProductoCreateDto request, int id)
        {
            return await Data.put(request, id);
        }
    }
}
