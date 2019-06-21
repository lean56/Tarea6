using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tarea6.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.Entidades;

namespace Tarea6.BLL.Tests
{
    [TestClass()]
    public class ComprasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Compras> db = new RepositorioBase<Compras>();
            List<DetalleCompras> lista = new List<DetalleCompras>();
            lista.Add(new DetalleCompras()
            {
                CompraId = 1,
                DetalleCompraId = 1,
                Unidades = 50,
                Total = 50,
                CostoUnidad = 500,
                ProductoId = 1
            });
            lista.Add(new DetalleCompras()
            {
                CompraId = 1,
                DetalleCompraId = 1,
                Unidades = 100,
                Total = 140,
                CostoUnidad = 390,
                ProductoId = 1
            });

            Compras compra = new Compras()
            {
                CompraId = 1,
                TipoComprobanteId = 1,
                ProveedorId = 1,
                UsuarioId = 1,
                FechaCompra = DateTime.Now,
                CostoCompra = 100,
                Detalles = lista
            };
            Assert.IsTrue(db.Guardar(compra));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Compras> db = new RepositorioBase<Compras>();
       
            Compras compra = new Compras()
            {
                CompraId = 1,
                TipoComprobanteId = 1,
                ProveedorId = 1,
                UsuarioId = 1,
                FechaCompra = DateTime.Now,
                CostoCompra = 300
                
            };
            Assert.IsTrue(db.Modificar(compra));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Compras> db = new RepositorioBase<Compras>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Compras> db = new RepositorioBase<Compras>();

            Assert.IsNotNull(db.Buscar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Compras> db = new RepositorioBase<Compras>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}