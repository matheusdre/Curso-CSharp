using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CursoCSharp.ClassesEMetodos {
    class Produto {
        //criando as atributos de produto
        private string nome;
        public string Nome {
            get//retornar o nome do produto com letra maiuscula
            { return nome.ToUpper(); }
            //aqui vou continuar atribuindo um valor para nome
            set { nome = value; }
        }
        private double preco;
        public double Preco {
            get { return preco; }
            /*vamos definir uma lógica para que os precos
             * não sejam menores que 5, 5 será o valor mínimo */
            set {
                if (value < 5.00) {
                    preco = 5.00;
                } else { /*caso contrário, eu atribuo o valor ao preco */
                    preco = value;
                }
            }
        }
        private double desconto = 0.05;
        public double Desconto {

            get {

                return desconto;//vou deixar o desconto fixo,
                                //não vamos atribuir nenhum valor 
            }
        }
        private double precoFinal;
        public double PrecoFinal {
            get {

                return Preco - (Preco * Desconto);
            }
        }
        public int EstoqueMinimo { get; set; }
    }
    class GetESetSegundoExemplo {
        public static void Executar() {
            //instanciando o produto
            Produto p1 = new Produto();
            p1.Nome = "Torcida Queijo";
            p1.Preco = 1.99;
            p1.EstoqueMinimo = 10;

            Console.WriteLine($"NOME: {p1.Nome} \n PREÇO: {p1.Preco.ToString("C")} \n DESCONTO: {p1.Desconto} \n PREÇO FINAL: {p1.PrecoFinal.ToString("C")} \n ESTOQUE MINIMO: {p1.EstoqueMinimo}");

            


        }
    }
}