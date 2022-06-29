using Common.Utilities;
using Data.Common;
using Data.Interfaces;
using Data.ModelData;
using DTO.Transport.Producto;

namespace Data.Implementations
{
    public class ProductoData : IProductoData
    {
        private readonly IRepository<Producto> Repo;
        public ProductoData(IRepository<Producto> repo)
        {
            Repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        public async Task<ProductoCreateDto> create(ProductoCreateDto request)
        {
            Producto create = request.Clone<ProductoCreateDto, Producto>();
            Producto result = await Repo.CreateAsync(create);
            return result.Clone<Producto, ProductoCreateDto>();
        }


        public async Task<bool> delete(int id)
        {
            Producto rowExists = (from row in Repo.Entity where row.Id == id select row).FirstOrDefault();
            if (rowExists == null)
                return false;
            await Repo.Delete(rowExists);
            return true;
        }

        public async Task<ICollection<ProductoGetDto>> get()
        {
            ICollection<Producto> items = (from rows in Repo.Entity select rows).ToList();
            ICollection<ProductoGetDto> response = items.Clone<Producto, ProductoGetDto>();
            return response;
        }

        public async Task<ProductoGetDto> get(int id)
        {
            Producto rowExists = (from row in Repo.Entity where row.Id == id select row).FirstOrDefault();
            ProductoGetDto response = rowExists.Clone<Producto, ProductoGetDto>();
            return response;
        }

        public async Task<ProductoCreateDto> put(ProductoCreateDto request, int id)
        {
            Producto rowExists = (from row in Repo.Entity where row.Id == id select row).FirstOrDefault();
            if (rowExists == null)
            {
                throw new Exception("El registro no existe");
            }
            else
            {
                rowExists.PrecioActual = request.PrecioActual;
                rowExists.Nombre = request.Nombre;
                rowExists.Stock = request.Stock;
                rowExists.IdProvedor = request.IdProvedor;

                Producto responseToClone = await Repo.Put(rowExists);
                ProductoCreateDto response = responseToClone.Clone<Producto, ProductoCreateDto>();
                return response;
            }
        }
    }
}
