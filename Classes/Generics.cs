using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdHelpers.Classes
{
    public static class Generics
    {
        public static void MainFunction()
        {
            //GENÉRICOS - São utilizados para a resolução de alguns problemas, como quando um determinado parâmetro pode receber
            //diferentes tipos-valor. Usamos o tipo object para referenciar uma instancia de qualquer classe, armazenar um valor
            //de qualquer tipo, definir parametros que podem ser de diferentes tipos e como tipo de retorno para qualquer coisa.

            Console.WriteLine("Retorna um String: " + Metodo.RetornaValor("Texto".ToUpper()));
            Console.WriteLine("Retorna um Double: " + Metodo.RetornaValor(10.45));
            Console.WriteLine("Retorna um Decimal: " + Metodo.RetornaValor(10.45m));
            Console.WriteLine("Retorna um Int: " + Metodo.RetornaValor(10));

            Console.WriteLine("\nPressione qualquer tecla...");
            Console.ReadKey();
            Console.Clear();

            //As desvantagem do object é que na verdade consome mais recurso de memória e demora do compilador. Pois há necessidade
            //de um CAST em tempo de execução, além do que, pode ocorrer erro de compilações quando o retorno não for previamente esperado
            //na continuação do programa.

            //Como solução a essas desvantagens e para, de fato, eliminar o uso dos OBJECTs, usamos os genéricos que elimina a necessidade
            //de casting , melhora a segurança dos tipos e facilita a criação de métodos e classes genéricas.

            //Usando uma classe genérica que pode armazenar diferentes tipos
            Console.WriteLine(
                string.Concat(                
                    Generics<decimal>.MetodoGenerico(decimal.MinValue),
                    Environment.NewLine,

                    Generics<decimal>.MetodoGenerico(10.5m),
                    Environment.NewLine,

                    Generics<decimal>.MetodoGenerico(decimal.MaxValue),
                    Environment.NewLine,

                    Generics<int>.MetodoGenerico(int.MinValue),
                    Environment.NewLine,

                    Generics<int>.MetodoGenerico(105),
                    Environment.NewLine,

                    Generics<int>.MetodoGenerico(int.MaxValue),
                    Environment.NewLine,

                    Generics<long>.MetodoGenerico(long.MinValue),
                    Environment.NewLine,

                    Generics<long>.MetodoGenerico(105),
                    Environment.NewLine,

                    Generics<long>.MetodoGenerico(long.MaxValue),
                    Environment.NewLine,

                    Generics<double>.MetodoGenerico(double.MinValue),
                    Environment.NewLine,

                    Generics<double>.MetodoGenerico(105),
                    Environment.NewLine,

                    Generics<double>.MetodoGenerico(double.MaxValue),
                    Environment.NewLine,

                    Generics<string>.MetodoGenerico(string.Empty),
                    Environment.NewLine,

                    Generics<string>.MetodoGenerico("Texto"),
                    Environment.NewLine,

                    Generics<string>.MetodoGenerico(("Texto").ToUpper()),
                    Environment.NewLine,

                    Generics<DateTime>.MetodoGenerico(DateTime.MinValue),
                    Environment.NewLine,

                    Generics<DateTime>.MetodoGenerico(DateTime.Now),
                    Environment.NewLine,

                    Generics<DateTime>.MetodoGenerico(DateTime.MaxValue),
                    Environment.NewLine,

                    Generics<int[]>.MetodoGenerico(new int[1])
                )
            );

            Console.ReadKey();
            Console.Clear();
        }
    }

    public static class Metodo
    {
        public static object RetornaValor(object obj)
        {
            return obj;
        }
    }

    public static class Generics<T>
    {
        public static string MetodoGenerico(T value)
        {
            if (value is string)
            {
                return $"O value é string: {value}";
            }
            else if (value is decimal)
            {
                return $"O value é decimal: {value}";
            }
            else if (value is int)
            {
                return $"O value é int: {value}";
            }
            else if (value is double)
            {
                return $"O value é double: {value}";
            }
            else if (value is long)
            {
                return $"O value é long: {value}";
            }
            else if (value is DateTime)
            {
                return $"O value é DateTime: {value}";
            }
            else
            {
                return "Outro tipo";
            }
        }
    }
}
