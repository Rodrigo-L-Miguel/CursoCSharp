using System;

namespace ExFixacaoMatriz
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert the dimentions: ");
            string[] dimentions = Console.ReadLine().Split(' ');//Get the dimentions for the matriz


            double[,] matrix = new double[int.Parse(dimentions[0]), int.Parse(dimentions[1])];

            //fill in the matrix
            for (int i = 0; i < int.Parse(dimentions[0]); i++)
            {
                Console.Write("Inform the numbers of the line " + i + ": ");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < int.Parse(dimentions[1]); j++)
                {
                    matrix[i, j] = double.Parse(values[j]);
                }
            }

            //Print the matrix
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

            // Search number in the matrix and inform his position and the number around him 
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