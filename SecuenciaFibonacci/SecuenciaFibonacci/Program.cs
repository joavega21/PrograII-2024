using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuenciaFibonacci {
    class Program {
        static void Main(string[] args) {
            Boolean continuar = true;
            while (continuar) {
                Console.Clear();
                int a = 1, b = 0, c = 0;
                do {
                    Console.WriteLine("{0} + {1} = {2}", a, b, c);
                    c = a + b;
                    b = a;
                    a = c;
                } while (c < 1000);
            }
        }
    }
}
