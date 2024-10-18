﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraComum {
        
        //criando os métodos da calculadora
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }


    }

    class MetodosComRetorno {
        
        
        public static void Executar() {

            // fazemdp a instancia do objeto
            var calculadoraComum = new CalculadoraComum();
            // chamando o método (função)
            var resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine(resultado);

            Console.WriteLine(calculadoraComum.Subtrair(15, 10));



           
        }

    }
}
