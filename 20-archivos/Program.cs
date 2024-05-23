using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20_archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1) crear archivo, 2) leer archivo");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                CAuto miAuto = new CAuto(modelo, costo);

                // variables extra
                int numero = 5;
                bool acceso = false;
                byte conteo = 120;

                // creamos el filestream
                FileStream fs = new FileStream("MiArchivo.arc", FileMode.Create, FileAccess.Write, FileShare.None);

                // creamos el editor
                BinaryWriter writer = new BinaryWriter(fs);

                // escribimos los atributos del objeto
                // ojo no estamos serializando

                writer.Write(miAuto.Modelo);
                writer.Write(miAuto.Costo);

                // Escribimos las variables
                writer.Write(numero);
                writer.Write(acceso);
                writer.Write(conteo);

                // cerramos el stream
                fs.Close();
            }

            if(opcion == 2)
            {
                // deserializamos el objeto
                Console.WriteLine("leer archivo");

                // creamos el stream
                Stream fs = new FileStream("MiArchivo.arc", FileMode.Open, FileAccess.Read, FileShare.None);

                // creamos el lector
                BinaryReader lector = new BinaryReader(fs);

                // leemos en el mismo orden
                // teniendo en cuenta el tipo

                string modelo = "";
                double costo = 0;
                int numero = 0;
                bool acceso = true;
                byte conteo = 0;

                modelo = lector.ReadString();
                costo = lector.ReadDouble();
                CAuto miAuto = new CAuto(modelo, costo);

                numero = lector.ReadInt32();
                acceso = lector.ReadBoolean();
                conteo = lector.ReadByte();

                // cerramos stream
                fs.Close();

                // imprimimos
                miAuto.MuestraInformacion();
                Console.WriteLine("numero {0}",numero);
                Console.WriteLine("acceso {0}",acceso);
                Console.WriteLine("conteo {0}", conteo);

            }

        }

    }
}
