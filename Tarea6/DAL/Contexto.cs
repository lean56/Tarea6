using System;
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
        public DbSet<Cargos> Cargo { get; set; }
        public DbSet<Categorias> Categoria { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Compras> Compra { get; set; }
        public DbSet<DetalleCompras>detalleCompra { get; set; }
        public DbSet<DetalleVenta> detalleVenta { get; set; }
        public DbSet<Empleados> empleado { get; set; }
        public DbSet<Estados> estado { get; set; }
        public DbSet<Imagenes> imagene { get; set; }
        public DbSet<Marcas> marca { get; set; }
        public DbSet<Modelos> modelo { get; set; }
        public DbSet<Permisos> permiso { get; set; }
        public DbSet<Personas>personas {get;set;}
        public DbSet<Productos>producto { get; set; }
        public DbSet<Proveedores>proveedore { get; set; }
        public DbSet<TipoComprobantes>tipoComprobante { get; set; }
        public DbSet<TipoPersonas> TipoPersona { get; set; }
        public DbSet<UnidadMedidas>unidadMedida { get; set; }
        public DbSet<Usuarios> usuario { get; set; }
        public DbSet<Usuarios_Has_Permisos> Usuarios_Has_Permiso { get; set; }
        public DbSet<Ventas> venta { get; set; }
       
        public Contexto() : base("Constr") { }
        
        public void FixEfProviderServicesProblem()
        {
            //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            //Make sure the provider assembly is available to the running application. 
            //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.

            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
