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
                CargoId = 1,
                NombreCargos = "Prueba 1",
                EstadoId = 1
            };

            Assert.IsTrue(db.Guardar(cargo));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Cargos cargo = new Cargos()
            {
                CargoId = 0,
                EstadoId = 1,
                NombreCargos = "Contabilidad"
            };

            Assert.IsTrue(db.Modificar(cargo));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}