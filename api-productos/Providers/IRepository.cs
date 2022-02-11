
using api_productos.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_productos.Providers
{
    public interface IRepository<T> where T : new()
    {
        Task<List<T>> Listar();

        Task<T> Insertar(T entiti);
        Task<T> Actualizar(T entiti);
        Task<T> Eliminar(int i);

        Task<T> Obtener(int i);

    }

    public interface IProductoRepositori : IRepository<Producto> { }



}