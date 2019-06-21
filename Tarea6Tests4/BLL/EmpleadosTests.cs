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
    public class EmpleadosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Empleados> db = new RepositorioBase<Empleados>();

            Empleados empleados = new Empleados()
            {
                EmpleadoId = 1,
                EstadoId = 1,
                CargoId=1,
                PersonaId=1
            };

            Assert.IsTrue(db.Guardar(empleados));
        }
    }
}