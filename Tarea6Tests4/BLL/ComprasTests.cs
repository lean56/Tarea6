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
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

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
        }
    }
}