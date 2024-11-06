using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Queue {
        public static void Executar() {
        

            var fila = new Queue<string>();

            //enfileiras
            fila.Enqueue("Alisson");
            fila.Enqueue("Matheus");
            fila.Enqueue("Tinti");
            fila.Enqueue("Luiz");
            fila.Enqueue("Enzo");

            // pega o primeiro da fila
            Console.WriteLine(fila.Peek());

            // conta quantos estão na fila
            Console.WriteLine(fila.Count);

            //removendo algum da fila
            Console.WriteLine(fila.Dequeue());

            Console.WriteLine(fila.Count());

            foreach( var pessoa in fila ) {
                Console.WriteLine(pessoa);
            }




        }

    }
    }

