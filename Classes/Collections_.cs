using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdHelpers.Classes
{
    public static class Collections_
    {
        public static void MainFunction()
        {
            //Tipos de coleção STACK, QUEUE, HASHTABLE, E A SORTEDLIST

            MetodoStack();
            MetodoQueue();
            MetodoHashtable();
            MetodoSortedList();

            Console.ReadKey();
        }

        private static void MetodoStack()
        {
            //-------------------------------------------------
            //STACK - os últimos a entrar na fila são os primeiros a sair
            // Push - coloca o item na pilha
            // Pop - retira o último item da pilha e retorna uma referência a este objeto
            // Peek - retorna o objeto que está na pilha
            Console.WriteLine("================ MetodoStack ============== ");
            string clubesInput = string.Empty;
            string clubesOutput = string.Empty;

            Stack pilha = new Stack();

            string[] array = { "CORINTHIANS", "CHELSEA", "BARCELONA", "MANCHESTER UNITED", "INTERNACIONAL" };            
            array.ToList().ForEach(x => clubesInput += string.Concat(x, ", "));
            
            Console.WriteLine($"Forma declarada do array: {clubesInput}");

            array.ToList().ForEach(x => pilha.Push(x));
            pilha.ToArray().ToList().ForEach(x => clubesOutput += string.Concat(x, ", "));

            Console.WriteLine($"Forma Stack do último para o primeiro: {clubesOutput}");

            //Exibindo o primeiro item
            Console.WriteLine("Stack - Usando pilha.Peek() para mostrar o item do topo: " + pilha.Peek());

            //Removendo o primeiro item da fila
            pilha.Pop();

            Console.WriteLine("Stack - Exibindo o item do topo após remoção em pilha.Pop() : " + pilha.Peek());
        }

        private static void MetodoQueue()
        {
            //-------------------------------------------------
            //QUEUE - os primeiros a entrar na fila são os primeiros a sair
            // Enqueue - coloca o item na fila
            // Dequeue - retira o primeiro item da fila e retorna uma referência 
            // Peek - retorna o primeiro item da fila

            Console.WriteLine("\n================ MetodoQueue ============== ");
            string clubesInput = string.Empty;
            string clubesOutput = string.Empty;

            Queue pilha = new Queue();

            string[] array = { "CORINTHIANS", "CHELSEA", "BARCELONA", "MANCHESTER UNITED", "INTERNACIONAL" };
            array.ToList().ForEach(x => clubesInput += string.Concat(x, ", "));

            Console.WriteLine($"Forma declarada do array: {clubesInput}");

            array.ToList().ForEach(x => pilha.Enqueue(x));
            pilha.ToArray().ToList().ForEach(x => clubesOutput += string.Concat(x, ", "));

            Console.WriteLine($"Forma Queue do primeiro na fila para o útlimo: {clubesOutput}");

            //Exibindo o primeiro item
            Console.WriteLine("Stack - Usando pilha.Peek() para mostrar o item do topo: " + pilha.Peek());

            //Removendo o primeiro item da fila
            pilha.Dequeue();

            Console.WriteLine("Stack - Exibindo o item do topo após remoção em pilha.Pop() : " + pilha.Peek());
        }

        private static void MetodoHashtable()
        {
            //-------------------------------------------------
            //HASHTABLE - permite trabalhar com um array associativo, ou seja, mantém internamente dois arrays de objetos
            //Trabalha com CHAVES e VALORES um pouco parecida com Sorted List.
            //Add - adiciona um item
            //ContainsKey - retorna true se a Hashtable contiver uma chave especifica
            //ContainsValue - retorna true se a Hashtable contiver um valor especifico
            //item - propriedade
            //A classe DictionaryEntry tem duas propriedades importantes: key e value

            Console.WriteLine("\n================ MetodoHashtable ============== ");

            //Instância
            Hashtable candidatos = new Hashtable();

            //Add itens
            candidatos["Josualdo"] = 120;
            candidatos["Marinalva"] = 128;
            candidatos["Tevez"] = 180;
            candidatos["Wilker"] = 166;
            candidatos["Lídia"] = 200;

            //Exibindo os valores
            foreach (DictionaryEntry item in candidatos)
            {
                Console.WriteLine(String.Format("Usando o Hastable para exibir key: {0} e value: {1}", item.Key, item.Value));
            }
        }

        private static void MetodoSortedList()
        {
            //-------------------------------------------------
            //SORTEDLIST - assim como a classe HashTable permite associação de chaves e valores, só com o detalhe de que,
            //independentemente da ordem que insiramos os pares chave / valor sempre serão ordenados pelas chaves

            Console.WriteLine("\n================ MetodoSortedList ============== ");

            //Instância
            SortedList candidatos = new SortedList();

            //Add itens
            candidatos["Josualdo"] = 120;
            candidatos["Marinalva"] = 128;
            candidatos["Tevez"] = 180;
            candidatos["Wilker"] = 166;
            candidatos["Lídia"] = 200;

            //Exibindo os valores
            foreach (DictionaryEntry item in candidatos)
            {
                Console.WriteLine(String.Format("Usando o SortedList para exibir key: {0} e value: {1}", item.Key, item.Value));
            }

            //Outra forma de inicializar um array
            SortedList candidatosList = new SortedList()
            {
                ["Josualdo"] = 120,
                ["Marinalva"] = 128,
                ["Tevez"] = 180,
                ["Wilker"] = 166,
                ["Lídia"] = 200
            };

            //Exibindo os valores
            foreach (DictionaryEntry item in candidatosList)
            {
                Console.WriteLine(String.Format("Usando o SortedList para exibir key: {0} e value: {1}", item.Key, item.Value));
            }
        }
    }
}
