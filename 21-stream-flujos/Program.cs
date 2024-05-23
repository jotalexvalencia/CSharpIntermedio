using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _21_stream_flujos
{
    class Program
    {
        static void Main(string[] args)
        {
            long cantidad = 0;
            long n = 0;
            int valor = 0;

            FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read, FileShare.None);

            // obtenemos la cantidad
            cantidad = fs.Length;
            Console.WriteLine("El archivo mide {0}", cantidad);

            // leemos byte por byte

            //for (n = 0; n < cantidad; n++)
            //{
            //    // ponemos la posicion
            //    fs.Seek(n, SeekOrigin.Begin);

            //    valor = fs.ReadByte();
            //    //typecast
            //    Console.WriteLine(" {0}", (char)valor);
            //}

            Console.WriteLine("\n----------------\n");

            //Leemos ahora en el otro sentido

            //for (n = 1; n <= cantidad; n++)
            //{
            //    // ponemos la posicion
            //    fs.Seek(-n, SeekOrigin.End);

            //    valor = fs.ReadByte();
            //    //typecast
            //    Console.WriteLine(" {0}", (char)valor);
            //}

            Console.WriteLine("\n----------------\n");

            fs.Seek(n, SeekOrigin.Begin);

            // leer sin conocer la longitud
            while ((valor = fs.ReadByte()) > 0)
            {
                Console.WriteLine(" {0}", (char)valor);

            }

            Console.WriteLine("\n----------------\n");

            fs.Close();
        }
    }
}
