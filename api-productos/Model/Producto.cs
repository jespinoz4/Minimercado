using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_productos.Model
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El codigo es requerido")]
        public string codigo { get; set; }

        [Required(ErrorMessage = "La descripcion es requerida")]
        public string descripcion { get; set; }
        [Required(ErrorMessage = "El precio es requerido")]
        public double precio { get; set; }
        [Required(ErrorMessage = "La cantidad es requerida")]
        public int cantidad { get; set; }

    }
}
