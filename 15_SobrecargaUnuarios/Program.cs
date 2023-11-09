using System;

namespace _15_SobrecargaUnuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario im3 = new CImaginario(1, 2);
            Console.WriteLine(im1);
            im1++;
            Console.WriteLine(im1);
            Console.WriteLine("---------");
            Console.WriteLine(im2);
            im2--;
            Console.WriteLine(im2);
            Console.WriteLine("---------");
            Console.WriteLine(im1);
            im1 += im2;
            Console.WriteLine(im1);
            Console.WriteLine("---------");
            CImaginario im4 = new CImaginario(1, 2);
            CImaginario im5 = new CImaginario(3, 4);
            CImaginario im6 = new CImaginario(1, 2);
            if (im4 == im6)
                Console.WriteLine("Son iguales");
            if(im5 != im6)
                Console.WriteLine("Son diferentes");
        }
    }
}
