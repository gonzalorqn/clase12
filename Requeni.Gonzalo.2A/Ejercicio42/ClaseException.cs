using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class ClaseException
    {
        public static int Metodo()
        {
            Console.Write("Ingrese un numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            int num2 = int.Parse(Console.ReadLine());
            return num1 / num2;
        }
        public ClaseException()
        {
            try
            {
                int i = ClaseException.Metodo();
            }
            catch(DivideByZeroException e)
            {
                new UnaException(e);
            }
        }

        public void MetodoInstancia()
        {
            new MiException();
        }
    }
}
