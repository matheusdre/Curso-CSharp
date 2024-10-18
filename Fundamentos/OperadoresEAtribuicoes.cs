using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresEAtribuicoes {
        public static void Executar() {

            {

                Console.WriteLine(" Digite seu sexo sendo  M  para masculino e F para feminino ");
                string letra = Console.ReadLine().ToUpper();

                if (letra == "M") {
                    Console.WriteLine("M - Masculino ");
                } else if (letra == "F") {
                    Console.WriteLine(" F - Feminino ");
                } else {
                    Console.WriteLine(" Sexo Inválido");
                }











            }
        }
    }
}

