using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

using System.Xml.Serialization;

namespace _18_Serializacion_SOAP_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region SERIALIZACION SOAP
            //{
            //    int opcion = 0;
            //    string valor = "";

            //    Console.WriteLine("1) crear y serializar auto, 2) leer auto");
            //    valor = Console.ReadLine();
            //    opcion = Convert.ToInt32(valor);

            //    if (opcion == 1)
            //    {
            //        // Creamos el objeto CAuto
            //        string modelo = "";
            //        double costo = 0;

            //        Console.WriteLine("Dame el modelo");
            //        modelo = Console.ReadLine();

            //        Console.WriteLine("Dame el costo");
            //        valor = Console.ReadLine();
            //        costo = Convert.ToDouble(valor);

            //        CAuto miAuto = new CAuto(modelo, costo);

            //        Console.WriteLine("Auto a serializar");
            //        miAuto.MuestraInformacion();

            //        // Empezamos la serializacion
            //        Console.WriteLine("--- Serializacion ---");

            //        // Seleccionamos el formateador
            //        SoapFormatter formateador = new SoapFormatter();

            //        // Se crea el stream
            //        Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

            //        // Serializamos
            //        formateador.Serialize(miStream, miAuto);

            //        // Cerramos el stream
            //        miStream.Close();
            //    }

            //    if (opcion == 2)
            //    {
            //        // Deserializamos el objeto
            //        Console.WriteLine("--- Deserializamos ---");

            //        // Seleccionamos el formateador
            //        SoapFormatter formateador = new SoapFormatter();

            //        // Creamos stream
            //        Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

            //        // Deserializamos
            //        CAuto miAuto = (CAuto)formateador.Deserialize(miStream);

            //        // Cerramos el stream
            //        miStream.Close();

            //        // Usamos el objeto
            //        Console.WriteLine("El auto deserializado es");
            //        miAuto.MuestraInformacion();
            //    }
            //}
            //#endregion

            #region SERIALIZACION XML
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

                    CAuto miAuto = new CAuto();
                    miAuto.Modelo = modelo;
                    miAuto.Costo = costo;

                    Console.WriteLine("Auto a serializar");
                    miAuto.MuestraInformacion();

                    // Empezamos la serializacion
                    Console.WriteLine("--- Serializacion ---");

                    // Seleccionamos el formateador
                    XmlSerializer formateador = new XmlSerializer(typeof(CAuto)); // se debe indicar el tipo

                    // Se crea el stream
                    Stream miStream = new FileStream("AutosXML.aut", FileMode.Create, FileAccess.Write, FileShare.None);

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
                    XmlSerializer formateador = new XmlSerializer(typeof(CAuto));

                    // Creamos stream
                    Stream miStream = new FileStream("AutosXML.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                    // Deserializamos
                    CAuto miAuto = (CAuto)formateador.Deserialize(miStream);

                    // Cerramos el stream
                    miStream.Close();

                    // Usamos el objeto
                    Console.WriteLine("El auto deserializado es");
                    miAuto.MuestraInformacion();
                }
            }
            #endregion
        }
    }
}
