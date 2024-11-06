using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Montadora;
        public string Marca;
        public int Ano;
        public int Potencia;

        public Carro(string modelo, string montadora, string marca, int ano, int potencia) {

            Modelo = modelo;
            Montadora = montadora;
            Marca = marca;
            Ano = ano;
            Potencia = potencia;

        }

        //método Acelerar
        public void Acelerar(string marca) {
            Console.WriteLine($"Acelerando.. {marca}");


        }
    }


    class ExercicioClassesEMetodos {
        public static void Executar() {

            var carros1 = new Carro("Chevrolet", "Coupe", "Camaro", 2024, 461);

            Console.WriteLine($" Modelo: {carros1.Modelo}, Montadora: {carros1.Montadora}, Marca: {carros1.Marca}, Ano: {carros1.Ano}, Potência:{carros1.Potencia}");

            carros1.Acelerar(carros1.Marca);

            Console.WriteLine();

            var carro2 = new Carro("lamborghini", "Coupe", " Revuelto", 2023, 1015);


            Console.WriteLine($" Modelo: {carro2.Modelo}, Montadora: {carro2.Montadora}, Marca: {carro2.Marca}, Ano: {carro2.Ano}, Potência:{carro2.Potencia}");

            carro2.Acelerar(carro2.Marca);


        }
    }
}

