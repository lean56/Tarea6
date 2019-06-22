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
    public class TipoComprobantesTests
    {

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            TipoComprobantes comprobantes = new TipoComprobantes()
            {
                ComprobanteId = 1,
                NombreComprobante ="prueba"
            };

            Assert.IsTrue(db.Guardar(comprobantes));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            TipoComprobantes comprobantes = new TipoComprobantes()
            {
                ComprobanteId = 2,
                NombreComprobante = "prueba..."
            };

            Assert.IsTrue(db.Modificar(comprobantes));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            Assert.IsNotNull(db.Buscar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}