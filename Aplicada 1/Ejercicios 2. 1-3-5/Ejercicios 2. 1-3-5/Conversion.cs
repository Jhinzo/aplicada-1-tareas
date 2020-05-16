using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_2._1_3_5
{
    class Conversion
    {
        public Conversion()
        {
            float d, t;
            string line;
            Console.WriteLine("Digite la cantidad de dolares que desea convertir: ");
            line = Console.ReadLine();
            d = float.Parse(line);
            Console.WriteLine("Digite la tasa: ");
            line = Console.ReadLine();
            t = float.Parse(line);
            Console.WriteLine("Cantidad en Euros: " + d * t);
            Console.ReadKey();
        }
    }
}
