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
    public class UsuariosTests
    {
        [TestClass()]
        public class CargosTests
        {
            [TestMethod()]
            public void GuardarTest()
            {
                RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

                Usuarios usuario = new Usuarios()
                {
                    UsuarioId = 1,
                    EmpleadoId = 1,
                    NombreUsuario = "admin",
                    Clave = "123"

                };

                Assert.IsTrue(db.Guardar(usuario));
            }

            [TestMethod()]
            public void ModificarTest()
            {
                RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

                Usuarios usuario = new Usuarios()
                {
                    UsuarioId = 1,
                    EmpleadoId = 1,
                    NombreUsuario = "administrator",
                    Clave = "admin123"
                };

                Assert.IsTrue(db.Modificar(usuario));
            }

            [TestMethod()]
            public void EliminarTest()
            {
                RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

                Assert.IsTrue(db.Eliminar(1));
            }

            [TestMethod()]
            public void BuscarTest()
            {
                RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

                Assert.IsNotNull(db.Buscar(1));
            }

            [TestMethod()]
            public void GetListTest()
            {
                RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

                Assert.IsNotNull(db.GetList(t => true));
            }
        }

    }
}