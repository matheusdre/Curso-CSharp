using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    class Heranca2 {

        public class Carro {

            /* readonly estará disponivel apenas
             para leitura (apenas leia ) */
            protected readonly int VelocidadeMaxima;
            int VelocidadeAtual;

            // criando construto de carro

            public Carro(int velocidadeMaxima) {

                VelocidadeMaxima = velocidadeMaxima;
            }

            /* vamos criar um método protegido
             * para  alterar a velocidade  */
            protected int AlterarVelocidade(int delta) {
                /* lógica para alterar a velocidade do carro */
                int novaVelocidade = VelocidadeAtual + delta;

                if (novaVelocidade < 0) {
                    /*caso a novaVelocidade seja maior
                     * do que a VelocidadeMaxima, não deixaremos
                     * o usuário ultrapassar essa velocidade */

                    VelocidadeAtual = 0;
                } else if (novaVelocidade > VelocidadeMaxima) {
                    VelocidadeAtual = VelocidadeMaxima;

                } else {
                    VelocidadeAtual = novaVelocidade;
                }

                return VelocidadeAtual;
            }

            public int Acelerar() {
                /* aqui teremos uma lógica para
                 * acelerar de 5km em 5km */
                return AlterarVelocidade(5);
            }

            public int Frear() {
                return AlterarVelocidade(-5);
            }




        }
        public class FordKa : Carro {

            public FordKa() : base(120) {

            }
        }

        public class Ferrari : Carro {
            
            public Ferrari() : base(340) {

            }
        }




        public static void Executar() {
            Console.WriteLine(" Ford Ka...");
            FordKa carro1 = new FordKa();

            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("FERRARI...");

            Ferrari carro2 = new Ferrari ();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());





        }


    }

}





