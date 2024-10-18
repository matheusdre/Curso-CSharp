using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class ExercicioSenha {
        public static void Executar() {

            Console.WriteLine(" Digite Sua Senha: ");
            string senha = Console.ReadLine();

            if (senha == "7taz9HvJ"){
                Console.WriteLine(" ACESSO PERMITIDO");
            }
            else {
                Console.WriteLine(" ACESSO NEGADO");
            }


        }
    }
}
