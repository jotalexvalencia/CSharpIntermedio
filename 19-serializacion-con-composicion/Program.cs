using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _19_serializacion_con_composicion
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = default;
            string valor = default;

            Console.WriteLine("1) crear y serializar auto, 2) leer auto");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if(opcion == 1)
            {
                // creamos el objeto CAuto
                string modelo = default;
                double costo = 0;
                int cilindros = 0;
                int hp = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("dame el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                Console.WriteLine("dame los cilindros");
                valor = Console.ReadLine();
                cilindros = Convert.ToInt32(valor);

                Console.WriteLine("dame los hp");
                valor = Console.ReadLine();
                hp = Convert.ToInt32(valor);

                CAuto miAuto = new CAuto();
                CMotor miMotor = new CMotor();

                miMotor.Cilindros = cilindros;
                miMotor.HP = hp;

                miAuto.Modelo = modelo;
                miAuto.Costo = costo;
                miAuto.Motor = miMotor;

                Console.WriteLine("Auto a serializar");
                miAuto.MuestraInformacion();

                // Empezamos la serialización
                Console.WriteLine("--- serializamos ---");

                // seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                // se crea el stream
                Stream mistream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write);

                // serializamos
                formateador.Serialize(mistream, miAuto);

                // Cerramos el stream
                mistream.Close();
            }

            if (opcion == 2)
            {
                // deserializamos el objeto
                Console.WriteLine("--- deserializamos ---");

                // seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                // Creamos el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                // deserializamos
                CAuto miAuto = (CAuto)formateador.Deserialize(miStream);

                // cerramos el stream
                miStream.Close();

                // usamos el objeto
                Console.WriteLine("El auto deserializado es");
                miAuto.MuestraInformacion();
            }
        }
    }
}
