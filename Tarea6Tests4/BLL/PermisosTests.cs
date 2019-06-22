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
    public class PermisosTests
    {

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Permisos> db = new RepositorioBase<Permisos>();

            Permisos permisos = new Permisos()
            {
                PermisoId = 1,
                Descripcion = "prueba",
                Funcionalidad="ff"
            };

            Assert.IsTrue(db.Guardar(permisos));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Permisos> db = new RepositorioBase<Permisos>();

            Permisos permisos = new Permisos()
            {
                PermisoId = 1,
                Descripcion = "p2",
                Funcionalidad = "ff"
            };

            Assert.IsTrue(db.Modificar(permisos));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Permisos> db = new RepositorioBase<Permisos>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Permisos> db = new RepositorioBase<Permisos>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Permisos> db = new RepositorioBase<Permisos>();

            Assert.IsNotNull(db.GetList(t => true));
        }

    }
}