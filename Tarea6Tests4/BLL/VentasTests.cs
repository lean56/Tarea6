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
    public class VentasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();

            Ventas venta = new Ventas()
            {
                VentaId = 1,
                UsuarioId = 1,
                ClienteId =1,
                ComprobanteId = 1,
                FechaVenta = DateTime.Now,
                Igv = 100,
                SubTotal = 100,
                CostoVenta = 100
            };

            Assert.IsTrue(db.Guardar(venta));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();

            Ventas venta = new Ventas()
            {

                VentaId = 1,
                UsuarioId = 1,
                ClienteId = 1,
                ComprobanteId = 1,
                FechaVenta = DateTime.Now,
                Igv = 100,
                SubTotal = 100,
                CostoVenta = 100
            };

            Assert.IsTrue(db.Modificar(venta));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}