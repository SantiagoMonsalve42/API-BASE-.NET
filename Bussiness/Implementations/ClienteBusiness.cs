using Bussiness.Interfaces;
using Data.Interfaces;
using DTO.Transport.Cliente;

namespace Bussiness.Implementations
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteData Data;
        public ClienteBusiness(IClienteData repo)
        {
            Data = repo ?? throw new ArgumentNullException(nameof(repo));
        }
        public async Task<ClienteCreateDto> create(ClienteCreateDto request)
        {
            return await Data.create(request);
        }

        public async Task<bool> delete(int id)
        {
            return await Data.delete(id);
        }

        public async Task<ICollection<ClienteGetDto>> get()
        {
           return await Data.get();
        }

        public async Task<ClienteGetDto> get(int id)
        {
           return await Data.get(id);
        }

        public async Task<ClienteCreateDto> put(ClienteCreateDto request, int id)
        {
            return await Data.put(request, id);
        }
    }
}
