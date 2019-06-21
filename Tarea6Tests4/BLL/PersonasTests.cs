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
    public class PersonasTests
    {
     
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Personas personas = new Personas()
            {
                PersonaId = 2,
                Dni = 123,
                Nombre = "p2",
                Materno = "p1",
                Paterno = "p2",
                FechaNacimiento = DateTime.Now,
                Telefono="809-999-9999",
                Correo =" p@",
                Sexo ='M',
                Direccion="sfm",
                TipoPersonaId=1     
            };

            Assert.IsTrue(db.Guardar(personas));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Personas personas = new Personas()
            {
                PersonaId = 1,
                Dni = 123,
                Nombre = "p1",
                Materno = "p1...",
                Paterno = "p2...",
                FechaNacimiento = DateTime.Now,
                Telefono = "809-999-9999",
                Correo = " p@",
                Sexo = 'M',
                Direccion = "sfm",
                TipoPersonaId = 1

            };

            Assert.IsTrue(db.Modificar(personas));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.Buscar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.GetList(t => true));
        }

    }
}