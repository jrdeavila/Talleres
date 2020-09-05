using System;

namespace NumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("entre 0 y : ");
            int p = int.Parse(Console.ReadLine());

            for(int i=0;i<x;i++)
            {
                Random v = new Random();
                var value = v.Next(0,p);
                Console.Write("{0} ", value);           
            }

            Console.WriteLine();
        }
    }
}
