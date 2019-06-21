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
    public class AssemblyInfo
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();
            List<TipoPersonas> lista = new List<TipoPersonas>();

            lista.Add(new TipoPersonas() { PersonaId = 1, Nombre = "P1" });
            lista.Add(new TipoPersonas() { PersonaId = 1, Nombre = "P2" });

            Personas persona = new Personas()
            {
                PersonaId = 5,
                Dni = 1,
                Nombre = "Juan",
                Materno = "prueba",
                Paterno = "prueba2",
                FechaNacimiento = DateTime.Now
           ,
                Telefono = "8093333333",
                Correo = "Prueba@",
                Sexo = 'M',
                Direccion = "SFM",
                Tipo = lista
            };

            Assert.IsTrue(db.Guardar(persona));
        }
    }
}