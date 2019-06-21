using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tarea6.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.Entidades;
using Tarea6.BLL;
using Tarea6.DAL;

namespace Tarea6.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        RepositorioBase<Persona> repositorio;

        

        [TestMethod()]
        public void GuardarTest()
        {
            var persona = new Persona() { PersonaId = 1, Dni = 333, Nombre = "juan perez", Materno = "Maria R", Paterno = "Jose N", FechaNacimiento = Convert.ToDateTime(2019 - 06 - 19), Telefono = "8099999332", Correo = "juanp@gmail.com", Sexo = 'M', Direccion = "SFM" };

            repositorio.Guardar(persona);
            
        }
        

          // _contexto.
          /*
          //RepositorioBase<Persona> repositorio;
          RepositorioBase<Persona>  repositorio;
          List<Persona> personas = new List<Persona>()
          {
              new Persona() {PersonaId=1,Dni=333,Nombre="juan perez",Materno="Maria R",Paterno="Jose N",FechaNacimiento=Convert.ToDateTime(2019-06-19),Telefono="8099999332",Correo="juanp@gmail.com",Sexo='M',Direccion="SFM"}
          };

          foreach (Persona persona in personas)
              repositorio.Guardar(personas);

          */

            //  repositorio.Guardar<Persona>(T);
            // repositorio.Guardar<Persona>();


            //repositorio = new RepositorioBase<Persona>();
        
    }
}