/*
 * Faça um método para realizar a multiplicação e a divisão de 2 números inteiros. Retorne e imprima os dois resultados.
 */
 
 using System;

namespace Exercicio_02
{
    class Program
    {
        // Calcula e retorna o valor do produto de 'a' por 'b' e o valor da divisão de 'a' por 'b'
        static double MultiplicaDivide(int a, int b, out double divisao)
        {
            double resultado;
            resultado = a * b;
            divisao = a / b;
            return resultado;
        }

        static void Main(string[] args)
        {
            // Declaração de variáveis
            int a, b;
            double resultado, divisao;

            // Recebendo valores do usuário
            Console.Clear(); // Limpa tela
            Console.WriteLine(); // Pula linha
            Console.Write("Entre com o valor de 'a': ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Entre com o valor de 'b': ");
            b = int.Parse(Console.ReadLine());

            // Chamando o método MultiplicaDivide
            resultado = MultiplicaDivide(a, b, out divisao);

            // Imprimindo o resultado
            Console.Clear(); // Limpa tela
            Console.WriteLine(); // Pula linha
            Console.Write("O valor da multiplicação de {0} por {1} é: {2}", a, b, resultado);
            Console.Write("O valor da divisão de {0} por {1} é: {2}", a, b, divisao);
            Console.ReadKey();  
        }
    }
}
