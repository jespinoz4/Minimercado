using api_productos.Model;
using api_productos.Providers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace api_productos.Controllers
{
    [Route("api/producto")]
    [ApiController]
    //[Authorize]
    public class ProductosController : ControllerBase
    {

        private readonly IDataService data;

        public ProductosController(IDataService data)
        {
            this.data = data;
        }
        [HttpGet]
        [Route("Listar")]
        public async Task<List<Producto>> Get()
        {

            return await this.data.ProductoRepositori.Listar();

        }


        [HttpPost]
        [Route("Insertar")]
        public async Task<Producto> Post([FromBody] Producto entity)
        {
            return await this.data.ProductoRepositori.Insertar(entity);
        }

        //[HttpPost]
        //[Route("Actualizar")]
        //public async Task<ResultadoEntity> Update([FromBody] UsuarioEntity usuarioEntity)
        //{

        //    return await this.data.UsuarioRepositori.Actualizar(usuarioEntity);

        //}

        //[HttpDelete]
        //[Route("Eliminar/{id}")]
        //public async Task<ResultadoEntity> Delete(int id)
        //{
        //    return await this.data.UsuarioRepositori.Eliminar(id);
        //}

        //[HttpGet]
        //[Route("Obtener/{id}")]
        //public async Task<ResultadoEntity> GetBayId(int id)
        //{
        //    return await this.data.UsuarioRepositori.Obtener(id);
        //}
    }
}
