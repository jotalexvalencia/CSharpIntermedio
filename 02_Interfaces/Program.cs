using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double vala = 0.0;
            double valb = 0.0;

            string valor = "";

            IOperacion operacion = new CSuma();

            while (opcion!=5)
            {
                Console.WriteLine("1-suma, 2-resta, 3-multi, 4-div, 5-salir");
                Console.WriteLine("Que opcion deseas?");
                valor= Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Dame el valor de a");
                valor= Console.ReadLine();
                vala = Convert.ToInt32(valor);

                Console.WriteLine("Dame el valor de b");
                valor= Console.ReadLine();
                valb = Convert.ToInt32(valor);

                // Polimorfismo
                if(opcion==1)
                    operacion = new CSuma();
                if (opcion == 2)
                    operacion = new CResta();
                if (opcion == 3)
                    operacion = new CMulti();
                if(opcion == 4)
                    operacion = new CDiv();

                // Aqui nuestro programa, trabaja en terminos
                // del concepto Operacion, en lugar de en
                // terminos de cosas concretas como suma, resta, multi, div

                operacion.calcular(vala, valb);
                operacion.mostrar();
            }
        }
    }
}
