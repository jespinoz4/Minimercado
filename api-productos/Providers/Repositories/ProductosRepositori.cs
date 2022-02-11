using api_productos.Domain;
using api_productos.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_productos.Providers.Repositories
{
    public class ProductosRepositori : IProductoRepositori
    {
        private readonly MySqlContext context;

        public ProductosRepositori(MySqlContext context)
        {
            this.context = context;
        }
        public async Task<Producto> Actualizar(Producto entity)
        {
            Producto product = new Producto();
            //result.exito = false;
            //try
            //{
            //    string query = "CALL sp_actualizar_frace_intencion (" + entity.Id + "," + entity.intencion + ",'" + entity.frace +"',"+entity.activo +")";

            //    var list = await this.context.Productos.FromSqlRaw(query).ToListAsync();
            //    result = list.FirstOrDefault();
            //    if (result.exito)
            //    {
            //        result.data = entity;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    result.exito = false;
            //    result.message = ex.Message;
            //}


            return product;
        }

        public async Task<Producto> Eliminar(int id)
        {
            Producto product = new Producto();
            //result.exito = false;
            //try
            //{
            //    string query = "CALL sp_eliminar_frace_intencion (" + id + ")";

            //    var list = await this.context.Respuesta.FromSqlRaw(query).ToListAsync();
            //    result = list.FirstOrDefault();

            //}
            //catch (Exception ex)
            //{
            //    result.exito = false;
            //    result.message = ex.Message;

            //}
            return product;
        }

        public async Task<Producto> Insertar(Producto entity)
        {
            Producto product = new Producto();
            try
            {
                string query = "Insert into producto values ('" +entity.codigo+"','"+ entity.descripcion + "'," + entity.precio +","+entity.precio +")";

                var pres = await this.context.Productos.FromSqlRaw(query).ToListAsync();


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return product;
        }


        public async Task<List<Producto>> Listar()
        {
            List<Producto> productos = new List<Producto>();
         
            try
            {
                string query = "Select * from producto";
                var list = await this.context.Productos.FromSqlRaw(query).ToListAsync();
                productos = list;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return productos;
        }
        public async Task<Producto> Obtener(int id)
        {
            Producto producto = new Producto();
            //result.exito = false;
            //try
            //{
            //    string query = "CALL sp_obtener_frace_intencion (" + id + ")";
            //    var list = await this.context.Fraces.FromSqlRaw(query).ToListAsync();
            //    FracesEntity frace = list.FirstOrDefault();
            //    if (frace != null)
            //    {
            //        result.exito = true;
            //        result.data = frace;
            //        result.Id = frace.Id;
            //        result.message = "Correcto";
            //    }
            //    else
            //    {
            //        result.message = "Registro no encontrado";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    result.message = ex.Message;
            //    Console.WriteLine(ex.Message);
            //}

            return producto;
        }
    }
}

