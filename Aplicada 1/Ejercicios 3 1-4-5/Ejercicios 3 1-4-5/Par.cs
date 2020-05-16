using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_3_1_4_5
{
    class Par
    {
        namespace Ejercicios.Capitulo3
    {
        class Ejercicios1_4_5
        {
            public void Cap3_1()
            {
                int n;
                string line;
                Console.WriteLine("Digite un numero:");
                line = Console.ReadLine();
                n = int.Parse(line);
                if (n % 2 == 0)
                {
                    Console.WriteLine("Es par");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Es impar");
                Console.ReadKey();
            }
        }
}
