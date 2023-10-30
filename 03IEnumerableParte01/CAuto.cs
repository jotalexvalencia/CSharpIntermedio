using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03IEnumerableParte01
{
    class CAuto : IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        public CAuto(string Modelo,double Costo )
        => (costo, modelo) = (Costo, Modelo);
        

        public void CalculaTenencia(double imp)
        {
            tenencia = 5000.0 + costo * imp;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}",costo,tenencia);
            Console.WriteLine("Total {0}",costo+tenencia);
            Console.WriteLine("- - - - - - - - - -");
        }
    }
}
