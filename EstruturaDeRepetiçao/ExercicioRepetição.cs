using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeRepetiçao {
    class ExercicioRepetição {
        public static void Executar() {

            int soma = 0;
                
                for (int contador = 1; contador <= 10; contador++) {
                Console.WriteLine(" Digite um número ");
                int.TryParse(Console.ReadLine(), out int numero);

                soma += numero;



            }
            Console.WriteLine($" A soma dos números são  {soma}");

        }
    }
}
