using SumaEnteroMayorQue0.Servicios;

namespace SumaEnteroMayorQue0
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n1;

            MenuInterfaz mi = new MenuImplementacion();
            n1 = mi.pedirNum();

            MenuInterfaz mi1 = new MenuImplementacion();
            n1 = mi1.operacionSuma(n1);
        }
    }
}