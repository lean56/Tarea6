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
    public class ModelosTests
    {
        
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Modelos> db = new RepositorioBase<Modelos>();

            Modelos modelos = new Modelos()
            {
                ModeloId = 2,
                NombreModelo="p2"
            };

            Assert.IsTrue(db.Guardar(modelos));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Modelos> db = new RepositorioBase<Modelos>();

            Modelos modelos = new Modelos()
            {
                ModeloId = 1,
                NombreModelo = "prueba"
            };

            Assert.IsTrue(db.Modificar(modelos));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Modelos> db = new RepositorioBase<Modelos>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Modelos> db = new RepositorioBase<Modelos>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Modelos> db = new RepositorioBase<Modelos>();

            Assert.IsNotNull(db.GetList(t => true));
        }

    }
}