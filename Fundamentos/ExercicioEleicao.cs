using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class ExercicioEleicao {
        public static void Executar() {
            Console.WriteLine(" Digite o ano que você nasceu");
            int anoNasc = int.Parse(Console.ReadLine());


            Console.WriteLine(" Digite em que ano estamos?");
            int anoAtual = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNasc;

            if (idade > 18 && idade < 70) {
                Console.WriteLine($" Você tem {idade} , você pode votar !") ;
            } else {
                Console.WriteLine("Você não pode votar !");
            }

            
            
        }
    }
}
