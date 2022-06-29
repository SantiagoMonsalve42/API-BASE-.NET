using Common.Utilities;
using Data.Common;
using Data.Interfaces;
using Data.ModelData;
using DTO.Transport.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class ClienteData: IClienteData
    {
        private readonly IRepository<Cliente> Repo;
        public ClienteData(IRepository<Cliente> repo)
        {
            Repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        public async Task<ClienteCreateDto> create(ClienteCreateDto request)
        {
            Cliente create = request.Clone<ClienteCreateDto, Cliente>();
            Cliente result = await Repo.CreateAsync(create);
            return result.Clone<Cliente, ClienteCreateDto>();
        }


        public async Task<bool> delete(int id)
        {
            Cliente rowExists = (from row in Repo.Entity where row.Id == id select row).FirstOrDefault();
            if (rowExists == null)
                return false;
            await Repo.Delete(rowExists);
            return true;
        }

        public async Task<ICollection<ClienteGetDto>> get()
        {
            ICollection<Cliente> items = (from rows in Repo.Entity select rows).ToList();
            ICollection<ClienteGetDto> response = items.Clone<Cliente, ClienteGetDto>();
            return response;
        }

        public async Task<ClienteGetDto> get(int id)
        {
            Cliente rowExists = (from row in Repo.Entity where row.Id == id select row).FirstOrDefault();
            ClienteGetDto response = rowExists.Clone<Cliente, ClienteGetDto>();
            return response;
        }

        public async Task<ClienteCreateDto> put(ClienteCreateDto request, int id)
        {
            Cliente rowExists = (from row in Repo.Entity where row.Id == id select row).FirstOrDefault();
            if (rowExists == null)
            {
                throw new Exception("El registro no existe");
            }
            else
            {
                rowExists.IdTipoDocumento = request.IdTipoDocumento;
                rowExists.Nombre = request.Nombre;
                rowExists.Direccion = request.Direccion;

                Cliente responseToClone = await Repo.Put(rowExists);
                ClienteCreateDto response = responseToClone.Clone<Cliente, ClienteCreateDto>();
                return response;
            }
        }

    }
}
