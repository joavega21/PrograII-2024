using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabladeMultiplicar {
    class Program {
        static void Main(string[] args) {
            Boolean continuar = true;
            while (continuar) {
                Console.Write("Tabla: ");
                int tabla = int.Parse(Console.ReadLine());
                for(int i = 1; i <= 10; i++) {
                    Console.WriteLine("{0} X {1} = {2}", tabla, i, tabla * i);
                }
                Console.Write("Para continuar presione cualquier tecla, sino presione 's': ");
                continuar = !Console.ReadLine().Equals("s");
            }
        }
    }
}
