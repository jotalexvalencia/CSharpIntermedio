using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _04IEnumerableparte02
{
    class CContenedora : IEnumerable
    {
        private int[] valores = new int[10];

        public CContenedora()
        {
            for (int i = 0; i < 10; i++)
                valores[i] = i*i;
        }

        // implementamos el GetEnumerator necesario por IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (new ContenedorEnum(valores));

        }
    }

    class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        private int posicion = -1;

        public ContenedorEnum(int[] Arreglo)
        {
            arreglo = Arreglo;
        }

        public bool MoveNext()
        {
            posicion++;
            if(posicion < arreglo.Length) 
                return true;
            else
                return false;
        }

        public void Reset()
        {
            posicion = -1;
        }

        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }
    }
}
