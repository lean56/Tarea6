using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
   public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public int PersonaId { get; set; }
        public int EstadoId { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            PersonaId = 0;
            EstadoId = 0;
            FechaCreacion = DateTime.Now;
        }
    }
}
