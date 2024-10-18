using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class ExercicioSwitch {
        public static void Executar() {

            Console.WriteLine(" Digite o nome de um mês ( por exemplo: Janeiro, Fevereiro, etc..");
            string mes = Console.ReadLine().ToLower();


            switch (mes) {
                case "janeiro":
                    Console.WriteLine(" Este mês tem 31 dias");
                    break;
                
                case "fevereiro":
                    Console.WriteLine(" Este mês têm 28 ou 29 dias");
                    break;

                case " março":
                    Console.WriteLine("Este mês têm 31 dias");
                    break;

                case "abril":
                    Console.WriteLine(" Este mês têm 30 dias");
                    break;

                case "maio":
                    Console.WriteLine(" Este mês têm 31 dias");
                    break;

                case "junho":
                    Console.WriteLine(" Este mês têm 30 dias");
                    break;

                case "julho":
                    Console.WriteLine(" Este mês tem 31 dias");
                    break;

                case "agosto":
                    Console.WriteLine(" Este mês têm 31 dias");
                    break;

                case "setembro":
                    Console.WriteLine(" Este mês têm 31 dias");
                    break;

                case "outubro":
                    Console.WriteLine(" Este mês têm 31 dias");
                    break;

                case "novembro":
                    Console.WriteLine(" Este mês têm 30 dias");
                    break;

                case "dezembro":
                    Console.WriteLine(" Este mês têm 31 dias");
                    break;

                default:
                    Console.WriteLine(" Mês inválido. Por favor, digite um mês válido. ");
                    break;



            }


        }

    }
}
