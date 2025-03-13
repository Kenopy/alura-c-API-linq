using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ScreenSound_04.Desafios
{
    internal class Desafio_01_02
    {
        //Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b. Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.
        public static int LerNumero()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    return valor; // Retorna o número válido
                }
                Console.WriteLine("Entrada inválida! Digite um número inteiro:");
            }
        }

        public static double Dividir(int valorA, int valorB)
        {
            if (valorB == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return double.NaN; // Retorna "Not a Number" para indicar erro
            }

            return (double)valorA / valorB; // Converte para double antes da divisão para obter um resultado decimal
        }

        //Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente.Tratar a exceção apropriada.
    }
}
