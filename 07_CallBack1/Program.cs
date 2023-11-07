using System;

namespace _07_CallBack1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el refri
            CRefri miRefri = new CRefri(50, -20);

            Random rnd = new Random();

            // Creamos el sink
            // Sink1 tiene el codigo que se ejecutara cuando suceda el evento
            CRefriSink sink1 = new CRefriSink();

            // Adicionamos el sink al refri
            miRefri.AgregarSink(sink1);

            // El refri hace su trabajo
            while (miRefri.Kilos > 0)
            {
                // El refri trabaja y le sacamos kilos al azar
                miRefri.Trabajar(rnd.Next(1, 5));
            }
        }
    }
}
