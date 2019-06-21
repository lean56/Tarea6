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
                CargoId = 0,
                Nombre = "ds",
                EstadoId =  1
            };

            Assert.IsTrue(db.Guardar(cargo));
        }
    }
}