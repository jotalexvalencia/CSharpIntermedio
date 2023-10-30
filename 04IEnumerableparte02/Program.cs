using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04IEnumerableparte02
{
    class Program
    {
        static void Main(string[] args)
        {
            CContenedora contenedora = new CContenedora();

            foreach (int item in contenedora)
                Console.WriteLine(item);
        }
    }
}
