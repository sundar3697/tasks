using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    class Multiarray
    {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrix2 = new int[3, 3];

        public void matrixadd()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t" );

                }
                Console.WriteLine();

            }

            Console.WriteLine("\n multiplication \n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix2[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        matrix2[i, j] = matrix2[i,j]+ matrix[i,k] *  matrix[k, j];
                    }
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
