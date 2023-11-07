using System;
using System.Collections;

namespace _07_CallBack1
{
    class CRefri
    {
        // Aqui guardamos todos los sinks con los que se comunicara el refri
        private ArrayList listaSinks = new ArrayList();

        private int KilosAlimentos = 0;
        private int grados = 0;

        public CRefri(int pKilos, int pGrados)
        {
            // Coloca los valores iniciales del refri
            KilosAlimentos = pKilos;
            grados = pGrados;
        }

        // Con este metodo adicionamos un sink
        public void AgregarSink(IEventosRefri pSink)
        {
            if (pSink != null)
                listaSinks.Add(pSink);
        }

        // Con este metodo eliminamos un sink
        public void EliminarSink(IEventosRefri pSink)
        {
            if (listaSinks.Contains(pSink))
                listaSinks.Remove(pSink);
        }
        // Propiedades necesarias
        public int Kilos { get { return KilosAlimentos; } }
        public int Grados { get { return grados; } }

        public void Trabajar(int pConsumo)
        {
            // Actualizamos los kilos del refri
            KilosAlimentos -= pConsumo;
            // Subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados",KilosAlimentos,grados);

            // Hay que verificar si se cumple la condicion para
            // invocar los handlers del evento

            // Esta es la condicion del evento
            if (KilosAlimentos < 10)
            {
                // Inovamos a los handlers de cada sink
                foreach (IEventosRefri handler in listaSinks)
                {
                    handler.EReservasBajas(KilosAlimentos);
                }
            }
        }
    }
}
