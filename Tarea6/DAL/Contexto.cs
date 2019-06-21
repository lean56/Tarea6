﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.Entidades;

namespace Tarea6.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas>personas {get;set;}
        public DbSet<TipoPersonas> TipoPersona { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Cargos> Cargo { get; set; }
        public DbSet<Categorias> Categoria { get; set; }
        public DbSet<Compras> Compra { get; set; }
        public Contexto() : base("Constr") { }
    }
}
