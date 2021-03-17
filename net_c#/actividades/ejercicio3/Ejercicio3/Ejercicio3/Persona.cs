using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Persona
    {
        String nombre;
        String apellidos;
        int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona(string nombre, string apellidos, int edad)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
        }

        //    public void leerDatos() 
        //    {
        //        Console.WriteLine("Introduce nombre:");
        //        this.nombre = Console.ReadLine();

        //        Console.WriteLine("Introduce apellidos:");
        //        this.apellidos = Console.ReadLine();

        //        Console.WriteLine("Introduce edad:");
        //        this.edad = int.Parse(Console.ReadLine());
        //    }

        //    public void mostrarDatos()
        //    {
        //        Console.WriteLine("Mostrando datos...");
        //        Console.WriteLine("Nombre: " + this.nombre);
        //        Console.WriteLine("Apellidos: " + this.apellidos);
        //        Console.WriteLine("Edad: " + this.edad);
        //    }
    }
}
