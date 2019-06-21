using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
   public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public double CostoCompra { get; set; }
        public double Stock { get; set; }
        public int UnidadMedidaId { get; set; }
        public int ImagenId { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            FechaFabricacion = DateTime.Now;
            CostoCompra = 0;
            Stock = 0;
            UnidadMedidaId = 0;
            ImagenId = 0;
            CategoriaId = 0;
            MarcaId = 0;
            ModeloId = 0;
        }
    }
}
