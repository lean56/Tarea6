using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class TipoPersonas
    {
        [Key]
        public int TipoPersonaId { get; set; }
        public int PersonaId { get; set; }
        public string Nombre { get; set; }

        public TipoPersonas()
        {
            TipoPersonaId = 0;
            PersonaId = 0;
            Nombre = string.Empty;
        }
    }
}
