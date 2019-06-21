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
    public class DetalleVentaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<DetalleVenta> db = new RepositorioBase<DetalleVenta>();

            DetalleVenta detalle = new DetalleVenta()
            {
                DetalleVentaId = 1,
                VentaId = 1,
                ProductoId =1,
                Unidades = 1,
                CostoUnidad = 10,
                DescuentoUnidad = 1,
                Total = 9
            };

            Assert.IsTrue(db.Guardar(detalle));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<DetalleVenta> db = new RepositorioBase<DetalleVenta>();

            DetalleVenta detalle = new DetalleVenta()
            {
                DetalleVentaId = 1,
                VentaId = 1,
                ProductoId = 1,
                Unidades = 1,
                CostoUnidad = 10,
                DescuentoUnidad = 1,
                Total = 9
            };

            Assert.IsTrue(db.Modificar(detalle));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<DetalleVenta> db = new RepositorioBase<DetalleVenta>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<DetalleVenta> db = new RepositorioBase<DetalleVenta>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<DetalleVenta> db = new RepositorioBase<DetalleVenta>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}