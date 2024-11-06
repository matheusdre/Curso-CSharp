using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
 { 
    class Cliente 
    {
        // criando os atributos de cliente
        public string Nome;
        public string Cpf;
        public string Sexo;
        public string Endereco;
        public int Idade;

        // construtor que recebe parãmetros
        public Cliente(string nome, string cpf, string sexo, string endereco,int idade) {

            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Idade = idade;
        }

        public Cliente() {

        }


 
    }

    class Construtores {

        //vamos criar o objeto cliente a partir da classe Cliente
        public static void Executar() 
        {
            // construtor padrão
            var cliente1 = new Cliente();
            cliente1.Nome = "Luiz Fernando MS";
            cliente1.Cpf = "438.589.648-83";
            cliente1.Endereco = "Rua Petrogrado 1033";
            cliente1.Idade = 21;

            Console.WriteLine($"{cliente1.Nome} e {cliente1.Cpf}");

            var cliente2 = new Cliente("José,", "12345678", "m", "Parque das América", 70);

            var cliente3 = new Cliente() {
                Nome = "Enzo",
                Cpf = "434.674.598-97",
                Sexo = "M",
                Endereco = "Rua Bartira",
                Idade = 21


            };





        }
    }
}

        

    
