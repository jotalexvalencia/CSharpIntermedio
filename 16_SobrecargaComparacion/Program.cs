using System;

namespace _16_SobrecargaComparacion
{
    class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario im3 = new CImaginario(1, 2);

            if (im1 == im3)
                Console.WriteLine("Son iguales");
            if (im2 != im3)
                Console.WriteLine("Son diferentes");
            if (im1 < im3)
                Console.WriteLine("im1 es menor");
            if (im2 > im1)
                Console.WriteLine("im2 es mayor");
            if (im2 >= im1)
                Console.WriteLine("{0} es mayor o igual a {1}", im2, im1);
            if (im1 <= im3)
                Console.WriteLine("{0} es menor o igual a {1}", im1, im3);
        }
    }
}
