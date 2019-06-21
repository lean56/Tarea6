using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
   public class Proveedores
    {
        [Key]
        public int ProveedorId { get; set; }
        public int PersonaId { get; set; }

        public Proveedores()
        {
            ProveedorId = 0;
            PersonaId = 0;
        }
    }
}
