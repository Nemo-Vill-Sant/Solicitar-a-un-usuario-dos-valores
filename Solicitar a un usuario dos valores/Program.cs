using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitar_a_un_usuario_dos_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite valor de a");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor de b");

            double b = double.Parse(Console.ReadLine());

            double x = (a + b) * (a - b);

            double z = a * 2 - b;

            Console.WriteLine("Presionar cualquier tecla para cerrar");

            Console.ReadKey();
        }
    }
}
