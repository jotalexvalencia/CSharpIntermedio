using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_parametros_nombrados_opcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            // invocamos la función de forma normal
            // 3 posiciones
            mostrarDatos(3, 5, 7);

            // invocamos uno posicional 2 nombrados
            mostrarDatos(3, pC: 11, pB: 15);

            // OPCIONALES
            mostrarOpcionales();
            
            mostrarOpcionales(3);

            mostrarOpcionales(4, 5);

            mostrarOpcionales(pB: 15);

        }

        public static void mostrarDatos(int pA, int pB, int pC)
        {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);
            Console.WriteLine("--------------------");
        }

        public static void mostrarOpcionales(int pA=1, int pB=2, int pC=3)

        { 
            Console.WriteLine("PARAMETROS OPCIONALES");
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);
            Console.WriteLine("--------------------");
        }
    }
}
