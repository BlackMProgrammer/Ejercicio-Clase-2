using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el nombre del estudiante");

            String nombre = Console.ReadLine();

            Console.WriteLine("Digite la primera nota: ");
            string nota1val = Console.ReadLine();
            int nota1 = Convert.ToInt32(nota1val);

            Console.WriteLine("Digite la segunda nota: ");
            string nota2val = Console.ReadLine();
            int nota2 = Convert.ToInt32(nota2val);

            Console.WriteLine("Digite la tercena nota: ");
            string nota3val = Console.ReadLine();
            int nota3 = Convert.ToInt32(nota3val);

            Estudiante estudiante = new Estudiante(nombre,nota1,nota2,nota3);
            estudiante.promedio();
            
        }
    }
}
