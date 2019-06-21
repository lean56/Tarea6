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
    public class Usuarios_PermisosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> db = new RepositorioBase<Usuarios_Has_Permisos>();

            Usuarios_Has_Permisos permisos = new Usuarios_Has_Permisos()
            {
                UsuarioId = 1,
                PermisoId = 1
            };

            Assert.IsTrue(db.Guardar(permisos));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> db = new RepositorioBase<Usuarios_Has_Permisos>();

            Usuarios_Has_Permisos permisos = new Usuarios_Has_Permisos()
            {
                UsuarioId = 1,
                PermisoId = 2,
            };

            Assert.IsTrue(db.Modificar(permisos));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> db = new RepositorioBase<Usuarios_Has_Permisos>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> db = new RepositorioBase<Usuarios_Has_Permisos>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> db = new RepositorioBase<Usuarios_Has_Permisos>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}