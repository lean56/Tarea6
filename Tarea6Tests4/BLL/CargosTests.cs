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
    public class CargosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Cargos cargo = new Cargos()
            {
                CargoId = 2,
                NombreCargos = "Prueba 2",
                EstadoId = 2
            };

            Assert.IsTrue(db.Guardar(cargo));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Cargos cargo = new Cargos()
            {
                CargoId = 1,
                NombreCargos = "Contabilidad",
                EstadoId = 1
            };

            Assert.IsTrue(db.Modificar(cargo));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}