﻿/*
 * Faça um programa contendo uma sub-rotina que retorne 1 se o número digitado for positivo ou 0 se for negativo.
 */

using System;

namespace Exercicio_03
{
    class Program
    {

        // Método que retorna 1 caso o número lido for positivo ou 0 caso o número lido for negativo
        static int Subrotina(double num)
        {
            if (num >= 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            // Declaração de variáveis
            double num;
            int resultado;

            // Recebendo o valor do usuário
            Console.Clear(); // Limpa tela
            Console.WriteLine(); // Pula linha
            Console.Write("Entre com o valor do número: ");
            num = int.Parse(Console.ReadLine());

            // Chamando o método Subrotina
            resultado = Subrotina(num);

            // Imprimindo o resultado
            Console.Clear(); // Limpa tela
            Console.WriteLine(); // Pula linha
            Console.Write("O valor de retorno foi: " + resultado);
            if (resultado == 1)
            {
                Console.Write("Logo, o número é positivo.");
            }
            else if(resultado == -1)
            {
                Console.Write("Logo, o número é negativo.");
            }
            Console.ReadKey();
        }
    }
}
