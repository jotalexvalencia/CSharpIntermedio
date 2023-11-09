namespace _14_SobrecargaBinarios2
{
    class CImaginario
    {
        // Atributos
        private double entero;
        private double imaginario;

        public CImaginario(double pEntero, double pImaginario) =>
            (entero, imaginario) = (pEntero, pImaginario);

        // Propiedades
        public double Entero { get => entero; set => entero = value; }
        public double Imaginario { get => imaginario; set => imaginario = value; }

        // Para mostrar el numero imaginario
        public override string ToString()
        {
            if (imaginario < 0)
                return string.Format("({0}  {1}i)", entero, imaginario);
            else
                return string.Format("({0} + {1}i)", entero, imaginario);

        }

        // Sobrecarga de los operadores binarios
        // a= i1 + i2
        public static CImaginario operator +(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.Entero + i2.Entero;
            ri = i1.Imaginario + i2.Imaginario;

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }
        public static CImaginario operator -(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.Entero - i2.Entero;
            ri = i1.Imaginario - i2.Imaginario;

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator *(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = (i1.Entero * i2.Entero) - (i1.Imaginario * i2.Imaginario);
            ri = (i1.Entero * i2.Imaginario) + (i1.Imaginario * i2.Entero);

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }
        public static CImaginario operator /(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = ((i1.Entero * i2.Entero) + (i1.Imaginario * i2.Imaginario))
                / ((i2.Entero * i2.Entero) + (i2.Imaginario * i2.Imaginario));

            ri = ((i1.Imaginario * i2.Entero) - (i1.Entero * i2.Imaginario))
                / ((i2.Entero * i2.Entero) + (i2.Imaginario * i2.Imaginario));

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }
    }
}
