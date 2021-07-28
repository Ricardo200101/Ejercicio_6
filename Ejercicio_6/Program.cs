using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variable.

            double nota1, nota2, nota3, notafinal; 

            Console.WriteLine("INGRESAR NOTA 1: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("INGRESAR NOTA 2: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("INGRESAR NOTA 3: ");
            nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            // Calculos. 

            nota1 = (nota1 * 30) / 100;
            nota2 = (nota2 * 35) / 100;
            nota3 = (nota3 * 25) / 100;

            notafinal = nota1 + nota2 + nota3; 

            // Mostrar en pantalla.

            Console.WriteLine("NOTA 1 EQUIVALE A 30%: {0}", nota1);
            Console.WriteLine("NOTA 2 EQUIVALE A 35%: {0}", nota2);
            Console.WriteLine("NOTA 3 EQUIVALE A 25%: {0}", nota3);
            Console.WriteLine(" ");
            Console.WriteLine("SU NOTA FINAL ES: {0}", notafinal); 






            

            Console.ReadKey(); 
        }
    }
}
