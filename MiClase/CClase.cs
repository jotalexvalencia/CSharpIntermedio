using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    public class CClase
    {
        public static double Sumar(double x, double y) { return x + y; }
        public static double Restar(double x, double y) { return x - y; }

        public static double Dividir(double x, double y) 
        { 
            double r =default(double);

            r = y >0 ? x/y : y/x;
            return r; 
        }
    }
}
