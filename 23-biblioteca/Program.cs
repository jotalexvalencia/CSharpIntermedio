using System;
using MiClase;
namespace _23_biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            double r= 0;

            Console.WriteLine("Sumar");
            r = CClase.Sumar(5.4, 3.2);
            Console.WriteLine(r);

            Console.WriteLine("Restar");
            r = CClase.Restar(5.4, 3.2);
            Console.WriteLine(r);

            Console.WriteLine("Dividir con 0");
            r = CClase.Dividir(5.4, 0);
            Console.WriteLine(r);

            Console.WriteLine("Dividir");
            r = CClase.Dividir(5.4, 3.2);
            Console.WriteLine(r);
        }
    }
}
