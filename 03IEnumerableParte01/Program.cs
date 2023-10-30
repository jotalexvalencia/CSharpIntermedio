using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03IEnumerableParte01
{
    class Program
    {
        static void Main(string[] args)
        {
            CTiendaAutos tiendaAutos = new CTiendaAutos();

            foreach (CAuto miAuto in tiendaAutos)
            {
                miAuto.CalculaTenencia(0.05);
                miAuto.MuestraInformacion();
            }
        }
    }
}
