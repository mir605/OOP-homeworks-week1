// See https://aka.ms/new-console-template for more information

using System;

using System.Drawing;


public class Workplace
{
    static void Main(string[] args)
    {
        int[,] matrix = GetMatrix(6);
        PrintMatrix(matrix);
    }

    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];

        int minRow = 0, minCol = 0;//matrisin sol üst köşesi
        int maxRow = size - 1;// matrisin sağ alt köşesi
        int maxCol = size - 1;//matrisin sağ alt köşesi

        int TotalNum = size * size;//matristeki toplam değerler
        int CurrentNum = 1;//ilk değer

        while (CurrentNum <= TotalNum)
        {
           
            for (int i = minCol; i <= maxCol; i++) // üst satır doldurulur
            {
                matrix[minRow, i] = CurrentNum++;//mevcut değeri arttırır
            }
            minRow++;

            
            for (int i = minRow; i <= maxRow; i++)// sağ sütun doldurulur
            {
                matrix[i, maxCol] = CurrentNum++;//mevcut değeri arttırır
            }
            maxCol--;

           
            if (minRow <= maxRow) // sağ ve sol kolonun biribiri üzerine gelmesi durumunu kontrol eder
            {
                for (int i = maxCol; i >= minCol; i--) //sağ kolonu doldurur
                {
                    matrix[maxRow, i] = CurrentNum++;
                }
                maxRow--;
            }

           
            if (minCol <= maxCol) // üst ve alt kolonun biribiri üzerine gelmesi durumunu kontrol eder
            {
                for (int i = maxRow; i >= minRow; i--)//sol kolonu doldurur
                {
                    matrix[i, minCol] = CurrentNum++;
                }
                minCol++;
            }
        }

        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)//matrixi yazdırır
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

