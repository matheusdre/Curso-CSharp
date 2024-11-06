using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    class Heranca {
        public class Transporte {
            public void Iniciar() {
                Console.WriteLine("O transporte está em movimento");
            }
        }

        public class Bicicleta : Transporte {
            public void Pedalar() {
                Console.WriteLine("Pedalando com a Bicicleta");
            }
        }

        public static void Executar() {

            Bicicleta bicicleta = new Bicicleta();
            bicicleta.Iniciar(); // Método herdade de transporte
            bicicleta.Pedalar(); // Método especifico de Bicicleta
        }
    }
}