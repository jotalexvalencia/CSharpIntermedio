using System;

namespace _18_Serializacion_SOAP_XML
{
    [Serializable] // sus instancias las podemos almacenar en disco duro u otro medio
    public class CAuto
    {
        private double costo;
        private string modelo;

        public double Costo { set { costo = value; } get { return costo; } }
        public string Modelo { set { modelo = value; } get { return modelo; } }

        // Constructor
        public CAuto()
        {
            costo = 100000;
            modelo = "Vocho";
        }

        public void MuestraInformacion()
        {
            // Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("----------------");
        }
    }
}
