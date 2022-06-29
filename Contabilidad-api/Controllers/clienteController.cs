using Bussiness.Interfaces;
using DTO.Transport.Cliente;
using Microsoft.AspNetCore.Mvc;

namespace Contabilidad_api.Controllers
{
    public class clienteController:BaseController
    {
        private readonly IClienteBusiness Bussines;
        public clienteController(IClienteBusiness repo)
        {
            Bussines = repo ?? throw new ArgumentNullException(nameof(repo));
        }
        [HttpGet]
        public async Task<ActionResult> get()
        {
            return await GetReponseAnswer(await Bussines.get());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> get([FromRoute] int id)
        {
            return await GetReponseAnswer(await Bussines.get(id));
        }
        [HttpPost]
        public async Task<ActionResult> create([FromBody] ClienteCreateDto request)
        {
            return await GetReponseAnswer(await Bussines.create(request));
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> delete([FromRoute] int id)
        {
            return await GetReponseAnswer(await Bussines.delete(id));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> put([FromBody] ClienteCreateDto request, [FromRoute] int id)
        {
            return await GetReponseAnswer(await Bussines.put(request, id));
        }
    }
}
