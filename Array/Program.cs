using System;
using System.Collections.Generic;
using Array.Helper;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string> {"SP", "MG", "BA"};
            string[] estadosArray = new string[2] {"SC", "MT"};


            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            opLista.ImprimirListaString(estados);

            estados.AddRange(estadosArray);

            System.Console.WriteLine($"Quantidade de elementos atualizados na lista: {estados.Count}");
            opLista.ImprimirListaString(estados);

            estados.Insert(1, "RJ");
            System.Console.WriteLine($"Adicionando RJ na lista, total de elementos: {estados.Count}");
            opLista.ImprimirListaString(estados);


            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");

            // opLista.ImprimirListaString(estados);

            // OperacoesArray op =  new OperacoesArray();

            // int [] array = new int[5] {3,4,8,1,2,};
            // int [] arrayCopia = new int [10];
            // string[] arrayString = op.ConverterParaArrayString(array);


            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade do array após redimensionar: {array.Length}");

            // int valorProcurado = 8;
            // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice> -1)
            // {
            //     System.Console.WriteLine("O índice do elemento {0} é: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array.");
            // }

            // int valorProcurado = 9;
            // int valorAchado = op.ObterValor (array, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            // int valorProcurado = 0;
            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if (todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que não são maiores que {0}", valorProcurado);
            // }

            // int valorProcurado = 1;
            // bool existe = op.Existe(array, 1);

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor!");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }

            // int [] array = new int[5] {8,4,5,1,2,};
            // int [] arrayCopia = new int [10];


            // Bubble Sort
            
            // OperacoesArray op =  new OperacoesArray();
            // int [] array = new int[5] {8,4,5,1,2,};

            // System.Console.WriteLine("Array Original: ");
            // op.ImprimirArray(array);

            // op.OrdenarBubbleSort(ref array);

            // System.Console.WriteLine("Array Ordenado: ");
            // op.ImprimirArray(array);


            // Array Multidimensional

        //     int[,] matriz = new int [4,2]
        //     {
        //         {8, 8},
        //         {10, 5},
        //         {50, 14},
        //         {90, 150}
        //     };

        //     for (int i = 0; i < matriz.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < matriz.GetLength(1); j++)
        //         {
        //             System.Console.WriteLine(matriz[i, j]);
        //         }              
        //     }
        // }


            // Array

            // int[] arrayInteiros = new int [3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse ("30");
            // arrayInteiros[3] = 30;

            
            // foreach (int item  in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}

