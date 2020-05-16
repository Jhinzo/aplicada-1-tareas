using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_2._1_3_5
{
    class Poligono
    {
        public Poligono()
        {
            Console.WriteLine("Poligonos");
            int n;
            float l;
            string line;
            Console.WriteLine("Digite la cantidad de lados del poligono: ");
            line = Console.ReadLine();
            n = int.Parse(line);
            Console.WriteLine("Digite la longitud de uno de los lados poligono: ");
            line = Console.ReadLine();
            l = float.Parse(line);
            Console.WriteLine("El perimetro del poligono es: " + l * n);
            Console.ReadLine();
        }
    }
}
