﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
   public class Marcas
    {
        [Key]
        public int MarcasId { get; set; }
        public string NombreMarca { get; set; }

        public Marcas()
        {
            MarcasId = 0;
            NombreMarca = string.Empty;
        }
    }
}
