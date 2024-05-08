using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_serializacion_con_composicion_xml
{
    [Serializable]
    public class CMotor
    {
        private int cilindros;
        private int hp;

        public int Cilindros { get { return cilindros; } set { cilindros = value; } }
        public int HP { get { return hp; } set { hp = value; } }

        public CMotor()
        {
            cilindros = 4;
            hp = 200;
        }

        public CMotor(int pCilindros, int pHP)
        {
            cilindros = pCilindros;
            hp = pHP;
            
        }

        public void MuestraMotor()
        {
            Console.WriteLine("=== Cilindros:{0}, HP:{1}", cilindros, hp);
        }
    }
}
