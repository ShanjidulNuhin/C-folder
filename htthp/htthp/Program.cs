using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htthp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D jagged array
            int[][] jaggedarray = new int[2][];
            jaggedarray[0] = new int[] {1,2,3};
            jaggedarray[1] = new int[] {4,5};

            for (int i = 0; i < jaggedarray.Length; i++)//it is for outer loop of jagged array
            {
                for (int j = 0; j < jaggedarray[i].Length; j++)//inner loop for inner elements in jagged array
                {
                    Console.Write(jaggedarray[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n2D\n");
            //2D jagged array
            int[][,] jaggedArray = new int[3][,];
            jaggedArray[0]=new int[,] { { 1, 2, 3 },{ 4, 5, 6 } };
            jaggedArray[1]=new int[,]{ {  2, 3, 4 } };
            jaggedArray[2] = new int[,] { { 7, 8, 8 }, { 5, 6, 7 } };

            for (int i = 0;i < jaggedArray.Length; i++)//outer loop for jaggedArray
            {
                for (int j = 0;j < jaggedArray[i].GetLength(0); j++)//inner loop for row
                {
                    for(int k = 0;k<jaggedArray[i].GetLength(1); k++)//for columns
                    {
                        Console.Write(jaggedArray[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n3D\n");
//3D
int[][,,] jaggedArr = new int[2][,,];
jaggedArr[0] = new int[,,] { { { 1, 2, 3, 4 }, { 4, 5, 8, 5, } } };
jaggedArr[1] = new int[,,] { { { 6, 6, 6 },{ 9, 6,5 } } };

for (int i=0; i<jaggedArr.Length; i++)
{
    for(int j =0; j< jaggedArr[i].GetLength(0);j++)
    {
        for(int k = 0; k < jaggedArr[i].GetLength(1);k++)
        {
            for (int l = 0; l < jaggedArr[i].GetLength(2); l++)
            {
                Console.Write(jaggedArr[i][j, k, l] + " ");
            }
            Console.WriteLine();
        }
    }
}


            Console.ReadKey();
        }
    }
}
