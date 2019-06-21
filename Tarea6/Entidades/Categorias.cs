﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
   public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public Categorias()
        {
            CategoriaId = 0;
            NombreCategoria = string.Empty;
            Descripcion = string.Empty;
        }
    }
}
