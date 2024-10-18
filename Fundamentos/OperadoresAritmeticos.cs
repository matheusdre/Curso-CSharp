using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {

    class OperadoresAritmeticos {

        public static void Executar() {
            Console.WriteLine(" Digite Um Número :");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite Outro Número :");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"A soma total foi de ${soma}");

        }
    }
}

