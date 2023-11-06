using System;

namespace _05_ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            CAuto Auto1 = new CAuto("March", 1700000);

            // Aqui pensamos que hacemos clonado
            // Pero solo es otra variable referenciada a la misma instancia

            CAuto Auto2 = Auto1;

            Auto1.CalculaTenencia(0.10);
            Auto2.CalculaTenencia(0.10);

            // Imprimimos
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            Console.WriteLine("--------------------------------------------");

            // Hacemo un cambio, si fuera un clon solo uno cambia
            Auto1.Costo = 60000;

            // Imprimimos
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            Console.WriteLine("--------------------------------------------");

            // Ahora si hacemos un clon
            CAuto Auto3 = (CAuto)Auto1.Clone();

            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();
            Console.WriteLine("--------------------------------------------");

            // Modificamos uno, el otro no debe alterarse
            Auto1.Costo = 250000;

            // Imprimimos para verificar
            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();
            Console.WriteLine("--------------------------------------------");

        }
    }
}
