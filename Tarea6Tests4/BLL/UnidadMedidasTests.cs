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
    public class UnidadMedidasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<UnidadMedidas> db = new RepositorioBase<UnidadMedidas>();

            UnidadMedidas unidad = new UnidadMedidas()
            {
                UnidadMedidaId = 1,
                NombreUnidad ="p"  
            };

            Assert.IsTrue(db.Guardar(unidad));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<UnidadMedidas> db = new RepositorioBase<UnidadMedidas>();

            UnidadMedidas unidad = new UnidadMedidas()
            {
                UnidadMedidaId =1,
                NombreUnidad ="prueba"
            };

            Assert.IsTrue(db.Modificar(unidad));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<UnidadMedidas> db = new RepositorioBase<UnidadMedidas>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<UnidadMedidas> db = new RepositorioBase<UnidadMedidas>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<UnidadMedidas> db = new RepositorioBase<UnidadMedidas>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}