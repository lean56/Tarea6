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
    public class CategoriaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Categorias categoria = new Categorias()
            {
                CategoriaId = 2,
                NombreCategoria = "Trial 2",
                Descripcion = "Probando"
            };

            Assert.IsTrue(db.Guardar(categoria));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Categorias categorias = new Categorias()
            {
                CategoriaId = 1,
                NombreCategoria = "Prueba",
                Descripcion = "Probando..."
            };

            Assert.IsTrue(db.Modificar(categorias));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Assert.IsNotNull(db.Buscar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}