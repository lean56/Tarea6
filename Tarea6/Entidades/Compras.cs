using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
   public class Compras
    {
        [Key]
        public int CompraId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaCompra { get; set; }
        public int ProveedorId { get; set; }
        public int TipoComprobanteId { get; set; }
        public double CostoCompra { get; set; }

        public Compras()
        {
            CompraId = 0;
            UsuarioId = 0;
            FechaCompra = DateTime.Now;
            ProveedorId = 0;
            TipoComprobanteId = 0;
            CostoCompra = 0;
        }
    }
}
