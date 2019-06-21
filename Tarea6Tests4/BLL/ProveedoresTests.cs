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
    public class ProveedoresTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            Proveedores proveedores = new Proveedores()
            {
                ProveedorId = 2,
                PersonaId = 2
                
            };

            Assert.IsTrue(db.Guardar(proveedores));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            Proveedores proveedor = new Proveedores()
            {
                ProveedorId = 1,
                PersonaId = 1
            };

            Assert.IsTrue(db.Modificar(proveedor));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}