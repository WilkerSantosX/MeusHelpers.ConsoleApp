using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdHelpers.Classes
{
    public static class Arrays_
    {
        public static void MainFunction()
        {
            ArraySimples();
            ArrayMultiDimensional();
            ArrayPorParametro();
            ArrayCopiando();
        }

        private static void ArraySimples()
        {
            Console.WriteLine("ArraySimples - int[] array = new int[3]");

            int[] array = new int[3];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array - Posição: " + i + " - Valor:" + array[i]);
            }
        }

        private static void ArrayMultiDimensional()
        {
            Console.WriteLine(Environment.NewLine,
                "ArrayMultiDimensional - string[,] pesquisa = new string[5, 2]");

            int line = 5;
            int column = 2;

            string[,] pesquisa = new string[line, column];

            pesquisa[0, 0] = "Lidia";
            pesquisa[1, 0] = "Debora";
            pesquisa[2, 0] = "Darlene";
            pesquisa[3, 0] = "Sara";
            pesquisa[4, 0] = "Leiliane";

            pesquisa[0, 1] = "Solteira";
            pesquisa[1, 1] = "Solteira";
            pesquisa[2, 1] = "Casada";
            pesquisa[3, 1] = "Solteira";
            pesquisa[4, 1] = "Casada";


            //Primeiro for é percorrendo todos os elementos 
            for (int i = 0; i < line; i++)
            {
                //Segundo for é a impressão em pares dos valores
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(pesquisa[i, j]);
                }
            }
        }

        private static void ArrayPorParametro()
        {
            Console.WriteLine(Environment.NewLine,
                "ArrayPorParametro decimal[] numeros = { 10, 25, 40, 230, 500 };");

            decimal[] numeros = { 10, 25, 40, 230, 500 };

            Console.WriteLine("Resultado da média: " + CalcularMedia(numeros));
        }

        private static void ArrayCopiando()
        {
            Console.WriteLine(Environment.NewLine,
                "ArrayCopiando int[] grupoA = { 1, 2, 3, 4, 5 }; int[] grupoB = new int[grupoA.Length]");

            int[] grupoA = { 1, 2, 3, 4, 5 };
            int[] grupoB = new int[grupoA.Length];

            grupoA.CopyTo(grupoB, 0);

            for (int i = 0; i < grupoA.Length; i++)
            {
                Console.WriteLine("Array grupo A - Posição: " + i + " - Valor:" + grupoA[i]);
            }

            for (int i = 0; i < grupoB.Length; i++)
            {
                Console.WriteLine("Array grupo B - Posição: " + i + " - Valor:" + grupoB[i]);
            }

            Console.ReadKey();
        }

        private static decimal CalcularMedia(decimal[] valores)
        {
            decimal soma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }

            return soma / valores.Length;
        }
    }
}
