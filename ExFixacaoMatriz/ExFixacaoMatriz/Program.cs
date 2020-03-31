using System;

namespace ExFixacaoMatriz
{
    class Program
    {
        /*Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas 
         * contendo números inteiros, podendo haver repetições. Em seguida, ler um número inteiro X que pertence à matriz. 
         * Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver, 
         * conforme exemplo.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert the dimentions: ");
            string[] dimentions = Console.ReadLine().Split(' ');//coleta as dimensões da matriz.


            double[,] matrix = new double[int.Parse(dimentions[0]), int.Parse(dimentions[1])];//cria a matriz com as dimensões informadas

            //preenchimento da matriz
            for (int i = 0; i < int.Parse(dimentions[0]); i++)//percorre as linhas da matriz 
            {
                Console.Write("Inform the numbers of the line " + i + ": ");
                string[] values = Console.ReadLine().Split(' ');// coleta os dados informados para serem inseridos na linha

                for (int j = 0; j < int.Parse(dimentions[1]); j++)//percorre as colunas da matriz
                {
                    matrix[i, j] = double.Parse(values[j]);// preenche a linha da matriz com os valores informados 
                }
            }

            //Imprime na tela a matriz
            for (int i = 0; i < int.Parse(dimentions[0]); i++)
            {
                for (int j = 0; j < int.Parse(dimentions[1]); j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
           
            Console.Write("Inform the value to be located: ");
            double numberSearch = double.Parse(Console.ReadLine());

            // Busca o numero na matriz e informa sua posição
            for (int i = 0; i < int.Parse(dimentions[0]); i++)
            {
                for (int j = 0; j < int.Parse(dimentions[1]); j++)
                {
                    if (matrix[i,j] == numberSearch)
                    {
                        Console.WriteLine("Position: " + i +", "+j);
                        if(i > 0)
                            Console.WriteLine("Up:" + matrix[i-1,j]);
                        if (i < matrix.Rank)
                            Console.WriteLine("Down: " + matrix[i+1,j]);
                        if(j > 0)
                            Console.WriteLine("Left:" + matrix[i,j-1]);
                        if (i < matrix.Rank)
                            Console.WriteLine("Right: " + matrix[i,j+1]);
                    }
                }
                
            }





        }
    }
}