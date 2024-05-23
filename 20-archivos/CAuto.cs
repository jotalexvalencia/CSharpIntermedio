using System;

namespace _20_archivos
{

    class CAuto
    {
        private double costo;
        private string modelo;
        
        public double Costo { get { return costo; } set { costo = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }

        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }

        public void MuestraInformacion()
        {
            // Mostramos la información necesaria
            Console.WriteLine("Tu Automovil {0}", Modelo);
            Console.WriteLine("Costo {0}", Costo);
            Console.WriteLine("----------");
        }
    }
}
