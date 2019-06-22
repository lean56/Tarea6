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
    public class ImagenesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Imagenes> db = new RepositorioBase<Imagenes>();

            Imagenes imagenes = new Imagenes()
            {
                ImagenId = 2,
                RutaImagen ="d:"
            };

            Assert.IsTrue(db.Guardar(imagenes));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Imagenes> db = new RepositorioBase<Imagenes>();

            Imagenes imagenes = new Imagenes()
            {
                ImagenId = 1,
                RutaImagen = "documentos"
            };

            Assert.IsTrue(db.Guardar(imagenes));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Imagenes> db = new RepositorioBase<Imagenes>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Imagenes> db = new RepositorioBase<Imagenes>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Imagenes> db = new RepositorioBase<Imagenes>();

            Assert.IsNotNull(db.GetList(t => true));
        }

     
    }
}