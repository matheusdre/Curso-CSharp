using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Converter {

        public double realparaDolar(double real) {
            return real / 5.67;
        }

        public double celsiusFahrenheit(double celsius) {
            return celsius * 1.8 + 32;

        }

    }
}
    class ExercicioMetodosComRetornos {

    public static void Executar() {
        //  Cria uma instância da classe RealDolar 
        var conversor = new Converter();

        var dolar = conversor.realparaDolar(10);

        Console.WriteLine($" O valor em reais é {dolar.ToString("#.##")}");


        var resultado = new Converter();

        var fahreneit = conversor.celsiusFahrenheit(10);

        Console.WriteLine($" O valor de celsius para Fahrenheit é {fahreneit}");

    }




        

    }

 
    



