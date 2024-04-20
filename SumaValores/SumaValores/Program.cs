using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaValores {
    class Program {
        static void Main(string[] args) {
            int n1 = 0, n2 = 0, res = 0;
            Console.Write("Ingrese N1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese N2: ");
            n2 = int.Parse(Console.ReadLine());
            res = n1 + n2;
            Console.Write("El resultado es: " + res);
            Console.ReadKey();
        }
    }
}
