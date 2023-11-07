using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CallBack2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el refri
            CRefri miRefri = new CRefri(500, -20);

            Random rnd = new Random();

            // Creamos los sink
            CRefriSink sink1 = new CRefriSink();
            CTiendaSink sink2 = new CTiendaSink();

            // Adicionamos el sink al refri
            miRefri.AgregarSink(sink1);
            miRefri.AgregarSink(sink2);

            // El refri hace su trabajo
            while (miRefri.Kilos > 0 && sink1.Paro==false)
            {
                // El refri trabaja y le sacamos kilos al azar
                miRefri.Trabajar(rnd.Next(1, 5));
            }
        }
    }
}
