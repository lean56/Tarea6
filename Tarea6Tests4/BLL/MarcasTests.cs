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
    public class MarcasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Marcas> db = new RepositorioBase<Marcas>();

            Marcas marca = new Marcas()
            {
                MarcasId = 2,
                NombreMarca = "Honda"
            };

            Assert.IsTrue(db.Guardar(marca));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Marcas> db = new RepositorioBase<Marcas>();

            Marcas marca = new Marcas()
            {
                MarcasId = 1,
                NombreMarca = "Toyota"
            };

            Assert.IsTrue(db.Guardar(marca));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Marcas> db = new RepositorioBase<Marcas>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Marcas> db = new RepositorioBase<Marcas>();

            Assert.IsNotNull(db.Buscar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Marcas> db = new RepositorioBase<Marcas>();

            Assert.IsNotNull(db.GetList(t => true));
        }

       
    }
}