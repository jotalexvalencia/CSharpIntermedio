using System;
// Usings para poder serializar
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;

namespace _17_SerializacionBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1) crear y serializar auto, 2) leer auto");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                // Creamos el objeto CAuto
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                CAuto miAuto = new CAuto(modelo, costo);

                Console.WriteLine("Auto a serializar");
                miAuto.MuestraInformacion();

                // Empezamos la serializacion
                Console.WriteLine("--- Serializacion ---");

                // Seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                // Se crea el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                // Serializamos
                formateador.Serialize(miStream, miAuto);

                // Cerramos el stream
                miStream.Close();
            }

            if (opcion == 2)
            {
                // Deserializamos el objeto
                Console.WriteLine("--- Deserializamos ---");

                // Seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                // Creamos stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                // Deserializamos
                CAuto miAuto = (CAuto)formateador.Deserialize(miStream);

                // Cerramos el stream
                miStream.Close();

                // Usamos el objeto
                Console.WriteLine("El auto deserializado es");
                miAuto.MuestraInformacion();
            }
        }
    }
}
