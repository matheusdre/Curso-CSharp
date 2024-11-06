using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ExercicioArrays {
        public static void Executar() {

            string[] frutas = new string[10];

            frutas[0] = "Banana";
            frutas[1] = "Maça";
            frutas[2] = "Uva";
            frutas[3] = "limão";
            frutas[4] = "Laranja";
            frutas[5] = "Manga";
            frutas[6] = "Caqui";
            frutas[7] = "Ameixa";
            frutas[8] = "Abacate";
            frutas[9] = "Ameixa";

            frutas[2] = "Kiwi";
            frutas[frutas.Length - 1] = "Caqui";

            Array.Reverse(frutas);

            foreach (var fruta in frutas) {
                Console.WriteLine(fruta);
            };

            Console.WriteLine($"A quantidade de frutas é {frutas.Length}");

            Console.WriteLine($"A segunda fruta é {frutas[1]} e penúltima fruta é o {frutas[frutas.Length - 2]}");




        }
    
    }
}
