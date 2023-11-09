using System;

namespace _13_SobrecargaBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario imr;
            // Hacemos la suma
            imr = im1 + im2;
            Console.WriteLine("{0}+{1}={2}", im1, im2, imr);
        }
    }
}
