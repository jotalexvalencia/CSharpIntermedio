using System;

namespace _17_SerializacionBinaria
{
    [Serializable] // sus instancias las podemos almacenar en disco duro u otro medio
    class CAuto
    {
        private double costo;
        private string modelo;

        // Constructor
        public CAuto(string pModelo, double pCosto)
        {
            // Inicializamos los datos
            costo = pCosto;
            modelo = pModelo;
        }

        public void MuestraInformacion()
        {
            // Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}",modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("----------------");
        }
    }
}
