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
    public class EstadosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Estados> db = new RepositorioBase<Estados>();

            Estados estados = new Estados()
            {
                EstadoId = 1,
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now,
                Estado = "n"
            };

            Assert.IsTrue(db.Guardar(estados));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Estados> db = new RepositorioBase<Estados>();

            Estados estados = new Estados()
            {
                EstadoId = 1,
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now,
                Estado = "nuevo"
            };

            Assert.IsTrue(db.Modificar(estados));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Estados> db = new RepositorioBase<Estados>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Estados> db = new RepositorioBase<Estados>();

            Assert.IsNotNull(db.Buscar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Estados> db = new RepositorioBase<Estados>();

            Assert.IsNotNull(db.GetList(t => true));
        }

   
    }
}