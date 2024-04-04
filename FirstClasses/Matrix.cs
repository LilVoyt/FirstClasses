using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class Matrix
    {
        public int Row {  get; set; }
        public int Col { get; set; }
        public int[,] Array;

        public Matrix(int Row,  int Col)
        {
            this.Row = Row;
            this.Col = Col;

            Array = new int[Row, Col];
            Random rand = new Random();
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Array[i, j] = rand.Next(0, 100);
                }
            }
        }
        public Matrix(int[,] array)
        {
            this.Row = array.GetLength(0);
            this.Col = array.GetLength(1);
            Array = new int[Row, Col];
            Console.WriteLine("Array: ");
            for (int i = 0;i < array.GetLength(0); i++)
            {
                for(int j = 0;j < array.GetLength(1); j++)
                {
                    this.Array[i, j] = array[i,j];
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public int FindMax()
        {
            int max = 0;
            for(int i = 0; i < Row; i++)
            {
                for(int j = 0; j < Col; j++)
                {
                    if (Array[i, j] > max)
                    {
                        max = Array[i, j];
                    }
                }
            }
            return max;
        }
        public int FindMin()
        {
            int min = 0;
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    if (Array[i, j] < min)
                    {
                        min = Array[i, j];
                    }
                }
            }
            return min;
        }
    }
}
