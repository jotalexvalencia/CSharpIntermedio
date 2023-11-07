using System;

namespace _08_CallBack2
{
    class CRefriSink : IEventosRefri
    {
        // Esta es la clase sink
        private bool paro = false;
        public bool Paro { get { return paro; } }   

        // Aqui colocamos los handlers de los eventos definidos en la interfaz
        public void EReservasBajas(int pKilos)
        {
            // Aqui se coloca todo el codigo necesario para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimentos");
            Console.WriteLine("-->Quedan {0} kilos", pKilos);
        }
        public void EDescongelado(int pGrados)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("-->El refri se descongela");

            if(pGrados > 0)
                paro = true;
        }
    }
}
