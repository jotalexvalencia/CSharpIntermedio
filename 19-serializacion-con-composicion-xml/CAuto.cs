using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_serializacion_con_composicion_xml
{
    [Serializable]
    public class CAuto
    {
        //private double costo;
        //private string modelo;
        //private CMotor motor;

        //public double Costo {  set { costo = value; } get { return costo; } }
        //public string Modelo { set { modelo = value; } get { return modelo; } }
        //public CMotor Motor { set { motor = value; } }

        public double Costo { get; set; }
        public string Modelo { get; set; }
        public CMotor Motor { get; set; }

        public CAuto()
        {
            Costo = 100000;
            Modelo = "Vocho";
            Motor = new CMotor();
        }

        public CAuto(string pModelo, double pCosto, int pCilindros, int pHP)
        {
            Modelo = pModelo;
            Costo = pCosto;
            Motor = new CMotor();
        }

        public void MuestraInformacion()
        {
            // Mostramos la información necesaria
            Console.WriteLine("Tu Automovil {0}", Modelo);
            Console.WriteLine("Costo {0}", Costo);
            //motor.MuestraMotor();
            Motor.MuestraMotor();
            Console.WriteLine("----------");
        }
    }
}
