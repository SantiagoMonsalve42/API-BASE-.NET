using Bussiness.Interfaces;
using DTO.Transport.Producto;
using Microsoft.AspNetCore.Mvc;

namespace Contabilidad_api.Controllers
{
    public class productoController : BaseController
    {
        private readonly IProductoBusiness Bussines;
        public productoController(IProductoBusiness repo)
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
        public async Task<ActionResult> create([FromBody] ProductoCreateDto request)
        {
            return await GetReponseAnswer(await Bussines.create(request));
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> delete([FromRoute] int id)
        {
            return await GetReponseAnswer(await Bussines.delete(id));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> put([FromBody] ProductoCreateDto request, [FromRoute] int id)
        {
            return await GetReponseAnswer(await Bussines.put(request,id));
        }
    }
}
