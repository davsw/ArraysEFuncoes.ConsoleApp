using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEhFuncoes
{
    internal class Program
    {
        static void RemoverItem(int[] arrayValores)
        {
            for (int i = 0; i < 10; i++) 
            {
                int[] novoArray = new int[arrayValores.Length - 1];
                for (int j = 0; j < arrayValores.Length; j++)
                {
                    novoArray[i] = arrayValores[i];
                }
                Console.WriteLine($"Os valores com um item removido:{arrayValores[i]}");
            }
        }
        static void MostrarValores(int[] arrayValores)
        {
            

            for (int i = 0; i < arrayValores.Length; i++)
            {
                Console.WriteLine($"Os valores são: {arrayValores[i]}");
            }
        }

       public static void MaioresTresValores(int[] arrayValores)
        {
            int numMaior = int.MinValue;
            int numMaior2 = int.MinValue;
            int numMaior3 = int.MinValue;

            for (int i = 0; i < arrayValores.Length; i++)
            {
                if (arrayValores[i] > numMaior)
                {
                    numMaior3 = numMaior2;
                    numMaior2 = numMaior;
                    numMaior = arrayValores[i];
                }
                else if (arrayValores[i] > numMaior2)
                {
                    numMaior3 = numMaior2;
                    numMaior2 = arrayValores[i];
                }
                else if (arrayValores[i] > numMaior3)
                {
                    numMaior3 = arrayValores[i];
                }
            }
            Console.WriteLine($"Os três maiores valores são: {numMaior} {numMaior2} {numMaior3}");
        }
        static void MediaValor(int[] arrayValores)
        {
            int soma = 0;
            int media = 0;
            for (int i = 0; i < arrayValores.Length; i++)
            {

                soma += arrayValores[i];
                media = soma / arrayValores.Length;
            }

            Console.WriteLine("A média dos valores é: " + media);

        }
        static void MaiorValor(int[] arrayValores)
        {
            int maiorValor = arrayValores[0];

            for (int i = 0; i < arrayValores.Length; i++)
            {
                if (arrayValores[i] > maiorValor)
                {
                    maiorValor = arrayValores[i];
                }


            }
            Console.WriteLine("O maior número da sequência é: " + maiorValor);

        }
        static void MenorValor(int[] arrayValores)
        {
            int menorValor = arrayValores[0];

            for (int i = 0; i < arrayValores.Length; i++)
            {
                if (arrayValores[i] < menorValor)
                {
                    menorValor = arrayValores[i];
                }


            }
            Console.WriteLine("O menor número da sequência é: " + menorValor);

        }
        static void ValorNegativo(int[] arrayValores)
        {
            for (int i = 0; i < arrayValores.Length; i++)
            {
                if (arrayValores[i] < 0)
                {
                    Console.WriteLine($"Os valores negativos são: {arrayValores[i]}");
                }
            }
        }

     
        static void Main(string[] args)
        {
            int[] arrayValores = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

            Console.WriteLine("Atividade sobre Arrays, Funções e Programação Estruturada");
            MediaValor(arrayValores);
            MenorValor(arrayValores);
            MaiorValor(arrayValores);
            MaioresTresValores(arrayValores);
            ValorNegativo(arrayValores);
            MostrarValores(arrayValores);
            RemoverItem(arrayValores);
            Console.ReadLine();
        }

    }
}
