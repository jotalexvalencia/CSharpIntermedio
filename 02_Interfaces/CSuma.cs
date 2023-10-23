using System;
using System.Collections;

namespace _02_Interfaces
{
    class CSuma : IOperacion
    {
        private double r = 0;
        private ArrayList resultados = new ArrayList();

        // Metodos a implementar
        public void calcular(double a, double b)
        {
            r = a + b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la suma es {0}",r);
            resultados.Add(r);
        }

        // Metodos propios de la clase
        public void muestraResultados() 
        { 
            foreach(double r in resultados)
                Console.WriteLine(r);
        }
    }
}
