using DTO.Transport.Cliente;

namespace Data.Interfaces
{
    public interface IClienteData
    {
        Task<ICollection<ClienteGetDto>> get();
        Task<ClienteGetDto> get(int id);
        Task<ClienteCreateDto> put(ClienteCreateDto request, int id);
        Task<ClienteCreateDto> create(ClienteCreateDto request);
        Task<bool> delete(int id);
    }
}
