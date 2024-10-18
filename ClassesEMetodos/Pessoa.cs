using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        /*colocamos public porque eu quero que esse
         * atributo fique visivel para a minha classe
         imagine que na vida real, as pessoas precisam saber 
        do seu nome */
        public string Nome;
        public int Idade;
        public string Sexo;

        //método Apresentar
        public string Apresentar() {
            return string.Format($"Olá, eu sou {Nome} e eu tenho {Idade}");
        }

        //criando uma função vazia para chamar a função Apresentar
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}
