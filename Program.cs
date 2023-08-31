using System;
using System.Collections.Generic;
using System.Text;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int numAulm = 0;
            float nota = 0.0f;
            float prom = 0.0f;
            float sumNota = 0.0f;

            Console.WriteLine("Ingrese la cantidad de alumnos");
            numAulm = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= numAulm;i++)
            {
                Console.WriteLine("Ingrese la nota");
                nota = Convert.ToSingle(Console.ReadLine());

                sumNota += nota;

            }
            prom = sumNota / numAulm;

            Console.WriteLine("El promedio de notas es {0}" , prom);

            Console.ReadKey();
        }
    }
}
