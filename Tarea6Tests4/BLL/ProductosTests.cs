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
    public class ProductosTests
    {

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Productos producto = new Productos()
            {
                ProductoId = 1,
                Nombre = "p1",
                Descripcion = "p1",
                FechaFabricacion = DateTime.Now,
                CostoCompra =100,
                Stock =50,
                UnidadMedidaId =1,
                ImagenId = 1,
                CategoriaId =1,
                MarcaId =1,
                ModeloId =1
            };

            Assert.IsTrue(db.Guardar(producto));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Productos producto = new Productos()
            {
                ProductoId = 1,
                Nombre = "pp",
                Descripcion = "p1",
                FechaFabricacion = DateTime.Now,
                CostoCompra = 100,
                Stock = 50,
                UnidadMedidaId = 1,
                ImagenId = 1,
                CategoriaId = 1,
                MarcaId = 1,
                ModeloId = 1
            };

            Assert.IsTrue(db.Modificar(producto));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Assert.IsNotNull(db.Buscar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}