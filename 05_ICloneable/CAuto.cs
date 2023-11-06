using System;

namespace _05_ICloneable
{
    class CAuto : IAutomovil, ICloneable
    {
        private double costo;
        private double tenencia;
        private string modelo;

        public CAuto(string Modelo, double Costo)
        => (costo, modelo) = (Costo, Modelo);

        public double Costo { get => costo; set => costo = value; }
        public double Tenencia { get => tenencia; set => tenencia = value; }
        public void CalculaTenencia(double imp)
        {
            tenencia = 5000.0 + costo * imp;
        }
        public void MuestraInformacion()
        {
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total {0}", costo + tenencia);
            Console.WriteLine("- - - - - - - - - -");
        }
        public object Clone()
        {
            CAuto temp = new CAuto(modelo, costo);

            temp.Tenencia = tenencia;

            return temp;
        }
    }
}
