using System;

namespace _06_IComparable
{
    class CRectangulo : IComparable
    {
        private double ancho;
        private double alto;
        private double area;

        public CRectangulo(double pAncho, double pAlto)
        {
            ancho = pAncho;
            alto = pAlto;
            CalculaArea();
        }

        private void CalculaArea()
        {
            area = ancho * alto;
        }

        public override string ToString()
        {
            return string.Format("[{0}.{1}]={2}",ancho,alto,area);
        }
        // Implementación de IComparable
        public int CompareTo(object obj)
        {
            // Hacemos type cast con el objeto con el cual nos vamos a comparar
            CRectangulo temp = (CRectangulo)obj;

            // Si somos mas grandes que el objeto regresamos 1
            if (area > temp.area)
                return 1;
            // Si somos mas pequeños que el objeto regresamos -1
            if (area < temp.area)
                return -1;
            // Somos iguales al objeto regresamos 0
            return 0;
        }
    }
}
