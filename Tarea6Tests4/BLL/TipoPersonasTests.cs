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
    public class TipoPersonasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();

            TipoPersonas tpersona = new TipoPersonas()
            {
                TipoPersonaId = 1,
                PersonaId = 1,
                Nombre = "prueba"
            };

            Assert.IsTrue(db.Guardar(tpersona));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();

            TipoPersonas tipoPersonas = new TipoPersonas()
            {
                TipoPersonaId = 1,
                PersonaId = 2,
                Nombre = "p1"
            };

            Assert.IsTrue(db.Modificar(tipoPersonas));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}