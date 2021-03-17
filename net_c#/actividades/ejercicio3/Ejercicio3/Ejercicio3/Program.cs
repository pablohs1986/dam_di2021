using System;
using System.Collections.Generic;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();

            Persona persona1 = new Persona("Yoda", "García", 123);
            Persona persona2 = new Persona("Leia", "García", 50);
            Persona persona3 = new Persona("Vader", "García", 80);

            var personas = new List<Persona>();

            metodos.aniadirPersonaAlista(personas, persona1);
            metodos.aniadirPersonaAlista(personas, persona2);
            metodos.aniadirPersonaAlista(personas, persona3);

            metodos.listarPersonasEnLista(personas);



            //persona.leerDatos();
            //persona.mostrarDatos();
        }
    }
}
