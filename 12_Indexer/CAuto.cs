using System;

namespace _12_Indexer
{
    class CAuto
    {
        double costo;
        double tenencia;
        string modelo;

        // Constructor
        public CAuto(string pModelo, double pCosto)
        {
            // Inicializamos los datos
            costo = pCosto;
            modelo = pModelo;
        }

        public void MuestraInformacion()
        {
            // Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}",modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("----------");
        }
    }
}
