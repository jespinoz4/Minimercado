
using api_productos.Domain;
using api_productos.Providers.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace api_productos.Providers
{
    public class DataService : IDataService
    {
        private readonly MySqlContext context;


        public DataService(MySqlContext context)
        {
            this.context = context;

        }

        public IProductoRepositori ProductoRepositori =>  new ProductosRepositori(context);
    }
}