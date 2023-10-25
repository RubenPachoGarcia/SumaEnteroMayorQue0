using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaEnteroMayorQue0.Servicios
{
    internal class MenuImplementacion:MenuInterfaz
    {
        public int pedirNum()
        {
            int n1;
            Console.WriteLine("Introduzca un numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            return n1;
        }
        public int operacionSuma(int i) 
        {
            int suma=0;
            
            for (int n2 = 0; n2<=i; n2++)
            {
                suma += n2;
            }
            Console.WriteLine("El resultado es: " + suma);
            return suma;
        }
    }
}
