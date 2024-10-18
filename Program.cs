using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.EstruturaDeRepetiçao;
using CursoCSharp.ClassesEMetodos;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {" Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar },
                {" Exercicios - Fundamentos",Exercicios.Executar},
                {" Estrutura If - Estrutura de Controle ",EstruturaIf.Executar},
                {" Exercicio de If Else - Fundamentos " ,OperadoresEAtribuicoes.Executar},
                { " Exercicio de Senha - If Else - Fundamentos" ,ExercicioSenha.Executar },
                { " Exercicio Eleição - If Else - Fundamentos ",ExercicioEleicao.Executar },
                {" Estrutura Switch - Estrutura Switch ",EstruturaSwitch.Executar },
                { "Exercicio Switch - Estrutura Switch ",ExercicioSwitch.Executar },
                {" Estrutura While - Estrutura de Repetição " ,EstruturaWhile.Executar },
                {" Estrutura For -  Estrutura de Repetição",EstruturaFor.Executar },
                {" Exercicio Soma de números - Estrutura de Repetição",ExercicioRepetição.Executar },
                { "Estrutura ForEach - Estrutura de Repetição",EstruturaForEach.Executar },
                {" Membros - Classes e Metodos ",Membros.Executar },
                {" Construtores - Classes e Métodos",Construtores.Executar },
                {" Metodos com Retornos - Classes e Métodos",MetodosComRetorno.Executar },
                {" Exercicio Metodos - Classes e Métodos " ,ExercicioMetodosComRetornos.Executar }

            });
        
            central.SelecionarEExecutar();
        }
    }
}