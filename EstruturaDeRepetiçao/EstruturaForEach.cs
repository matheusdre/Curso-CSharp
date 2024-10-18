using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeRepetiçao {
    class EstruturaForEach {
        public static void Executar() {

            var palavra = "Corinthians";
            foreach(var letra in palavra) {
                Console.WriteLine(letra);
            }
            //percorrendo array
            var alunos = new string[] { "Corinthians", "Vasco", "SemMundial" };
            foreach(string aluno in alunos ) {
                Console.WriteLine(aluno);    
               

                   
                    

            
            }
        }
    }
}
