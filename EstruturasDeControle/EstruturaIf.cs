using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            Console.WriteLine(" Digite sua primeira nota :");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Digite sua segunda nota :");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Digite sua terceira nota :");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7) {
                Console.WriteLine($"Você não é uma pessoa leiga . Sua nota é  {media}");

            } else {
                Console.WriteLine($" Você um leigo. Peça ajuda para o Pedro H.S Sua nota é {media}");

            }

        }
    }
}
