using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {

        public static void Executar() {
            double valor = 45.2345;
            //arredondar
            Console.WriteLine(valor.ToString("F1"));

            // Transformar em valor monétario
            Console.WriteLine(valor.ToString("C"));

            //formatando do jeito que eu quero
            Console.WriteLine(valor.ToString("#.##"));

            //multiplica um valor por 100 e adiciona percentual
            Console.WriteLine(valor.ToString("P"));
        }
    }
}
