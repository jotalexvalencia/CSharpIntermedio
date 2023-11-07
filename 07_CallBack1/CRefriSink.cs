using System;

namespace _07_CallBack1
{
    class CRefriSink : IEventosRefri
    {
        // Esta es la clase sink
        // Aqui colocamos los handlers de los eventos definidos en la interfaz
        public void EReservasBajas(int pKilos)
        {
            // Aqui se coloca todo el codigo necesario para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimentos");
            Console.WriteLine("-->Quedan {0} kilos", pKilos);
        }
    }
}
