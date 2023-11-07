using System;

namespace _08_CallBack2
{
    class CTiendaSink : IEventosRefri
    {
        public void EReservasBajas(int pKilos)
        {
            // Aqui se coloca todo el codigo necesario para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--->Le enviaremos sus viveres");
            Console.WriteLine("--->Seran {0} kilos", pKilos);
        }

        public void EDescongelado(int pGrados)
        {
            // Handler vacio

        }
    }
}
