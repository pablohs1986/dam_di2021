using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[5];
            int numeroUsuario;
            int suma = 0;

            Console.Write("Introduce el número 1:");
            numeroUsuario = Int32.Parse(Console.ReadLine());
            arrayNumeros[0] = numeroUsuario;
            Console.Write("Introduce el número 2:");
            numeroUsuario = Int32.Parse(Console.ReadLine());
            arrayNumeros[1] = numeroUsuario;

            Console.Write("Introduce el número 3:");
            numeroUsuario = Int32.Parse(Console.ReadLine());
            arrayNumeros[2] = numeroUsuario;

            Console.Write("Introduce el número 4:");
            numeroUsuario = Int32.Parse(Console.ReadLine());
            arrayNumeros[3] = numeroUsuario;

            Console.Write("Introduce el número 5:");
            numeroUsuario = Int32.Parse(Console.ReadLine());
            arrayNumeros[4] = numeroUsuario;

            foreach (var numero in arrayNumeros)
            {
                suma+=numero;
            }
            Console.Write("La suma de los números es: " + suma);

        }
    }
}
