using DTO.Transport.Cliente;

namespace Bussiness.Interfaces
{
    public interface IClienteBusiness
    {
        Task<ICollection<ClienteGetDto>> get();
        Task<ClienteGetDto> get(int id);
        Task<ClienteCreateDto> put(ClienteCreateDto request, int id);
        Task<ClienteCreateDto> create(ClienteCreateDto request);
        Task<bool> delete(int id);
    }
}
