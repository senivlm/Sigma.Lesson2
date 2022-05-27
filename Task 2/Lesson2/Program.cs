using System;

namespace Lesson2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n = 4;
            Vector arr = new Vector(n);

            arr.InitRand(1, 20);
            Console.WriteLine(arr.ToString());

            arr.Bubble();
            Console.WriteLine(arr.ToString());

            arr.SplitMergeSort();
            Console.WriteLine(arr.ToString());

            //int[] mas = { 1, 2, 3, 4, 5, 6, 2, 1 };
            //Vector arr1 = new Vector(mas);
            ////Перевірка на паліндром
            //Console.WriteLine(arr1.IsPalindrom());

            ////Реверс масиву створеним методом
            //Console.WriteLine(arr1.ToString());
            //arr1.Reverse();
            //Console.WriteLine(arr1.ToString());

            ////Вбудований метод Reverse належить класу Array
            //Array.Reverse(mas);
            //Vector arr2 = new Vector(mas);
            //Console.WriteLine(arr2.ToString());

            //Оптимізовано InitShuffle
            //Vector arr3 = new Vector(10);
            //arr3.InitShuffle();
            //Console.WriteLine(arr3.ToString());

            //Vector arr4 = new Vector(22);
            //arr4.InitRand(-5, 15);
            //arr4.Counting();


            //Matrix matr = new Matrix(4);
            //matr.SortMatrixDiagonal(0);
            //Console.WriteLine(matr.ToString());
            //try
            //{
            //    Console.WriteLine(arr1[11]);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


        }

    }
}
