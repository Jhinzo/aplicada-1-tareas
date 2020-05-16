using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_2._1_3_5
{
    class Grados

    {
        public  Grados()
        {
            Console.WriteLine("GRADOS");
            
            double g;
            string line;
            
            Console.WriteLine("Digite los grados: ");
            line = Console.ReadLine();
            g = double.Parse(line);
            Console.WriteLine("Grados en Radianes: " + g * Math.PI / 180);
            Console.ReadKey();
        }
    }
}
