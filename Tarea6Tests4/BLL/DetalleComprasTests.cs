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
    public class DetalleComprasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<DetalleCompras> db = new RepositorioBase<DetalleCompras>();

            DetalleCompras detalle = new DetalleCompras()
            {
                DetalleCompraId = 1,
                CompraId = 1,
                ProductoId = 1,
                Unidades = 1,
                CostoUnidad = 10,
                Total = 9
            };

            Assert.IsTrue(db.Guardar(detalle));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<DetalleCompras> db = new RepositorioBase<DetalleCompras>();

            DetalleCompras detalle = new DetalleCompras()
            {
                DetalleCompraId = 1,
                CompraId = 1,
                ProductoId = 1,
                Unidades = 1,
                CostoUnidad = 10,
                Total = 9
            };

            Assert.IsTrue(db.Modificar(detalle));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<DetalleCompras> db = new RepositorioBase<DetalleCompras>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<DetalleCompras> db = new RepositorioBase<DetalleCompras>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<DetalleCompras> db = new RepositorioBase<DetalleCompras>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}