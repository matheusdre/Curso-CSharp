using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Exercicios {
        
        public static void Executar() {
            /*Console.WriteLine(" Digite sua primeira média :");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Digite sua segunda média :");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Digite sua terceira média :");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            Console.WriteLine($" Sua média é {media.ToString("F2")}"); */

            /* Console.WriteLine(" Digite o primeiro número :");
             double n1 = double.Parse(Console.ReadLine());

             Console.WriteLine(" Digite o segundo número :");
             double n2 = double.Parse(Console.ReadLine());

             double media = (n1 * 3.5 + n2 * 7.5) / 11;

             Console.WriteLine($" A soma dos pesos, portando é:{ media.ToString("F1")}"); */

            Console.WriteLine(" Digite o Código do funcionario");
            int funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o Número de horas trabalhadas");
            int horasTrab = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o valor que recebe por hora");
            double valorHora = double.Parse(Console.ReadLine());

            double resultado = (horasTrab * valorHora);

            Console.WriteLine($"  O funcionário de código {funcionario} deve receber : R$ {resultado}");

        }
    }

}
    
    
