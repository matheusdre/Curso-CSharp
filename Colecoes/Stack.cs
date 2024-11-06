using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Stacks {
        public static void Executar() {
            
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            //exibindo a pilha
            foreach(var item in pilha) 
                {
                Console.WriteLine($"{item}");

                }
                Console.WriteLine($"Pop: {pilha.Pop()}");

                foreach(var item in pilha) {

                    Console.WriteLine($"{item}");
                }
            }
            
        }
    }
 
