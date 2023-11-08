using System;

namespace _09_Delegados1
{
    class Radio
    {
        // Este método actuará como delegado
        public static void MetodoRadio(string Mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase radio");
            Console.WriteLine("Este es tu mensaje {0}", Mensaje);
        }
    }
}
