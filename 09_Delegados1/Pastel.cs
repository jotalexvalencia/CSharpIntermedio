using System;

namespace _09_Delegados1
{
    class Pastel
    {
        // Este método actuará como delegado
        public static void MostrarPastel(string Anuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pastel llevará el mensaje de {0}", Anuncio);
        }
    }
}
