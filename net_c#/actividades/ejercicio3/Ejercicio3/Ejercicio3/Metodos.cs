using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Metodos
    {
        public void aniadirPersonaAlista(List<Persona> personas, Persona persona)
        {
            personas.Add(persona);
        }

        public void borrarPersonaDeLista(List<Persona> personas, Persona persona)
        {
            personas.Remove(persona);
        }

        public void listarPersonasEnLista(List<Persona> personas)
        {
            foreach (var persona in personas)
            {
                Console.WriteLine(persona.Nombre);
                Console.WriteLine(persona.Apellidos);
                Console.WriteLine(persona.Edad);
                Console.WriteLine("______________________");
            }
        }
    }
}
