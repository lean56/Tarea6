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

            Compras compra = new Compras()
            {
                CompraId = 1,
                TipoComprobanteId = 1,
                ProveedorId = 1,
                UsuarioId = 1,
                FechaCompra = DateTime.Now,
                CostoCompra = 100,
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

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Compras> db = new RepositorioBase<Compras>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}