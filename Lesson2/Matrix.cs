using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Matrix
    {
        private int[,] matrix;
        private int n;

        
        

        public Matrix(int n)
        {
            matrix = new int[n, n];
            this.n = n;
        }
        public Matrix() { }
        
        /// <summary>
        /// Генерує змійку в матриці.
        /// Напрям залежить від числа, що вводиться як параметр
        /// При d парному змійка спочатку піде вниз, інакше праворуч
        /// </summary>
        /// <param name="d">Стартовий напрямок</param>
        public void SortMatrixDiagonal(byte d)
        {
            int num = 0;
            int difference = 0;
            for(int line = 0; line < n*2-1; line++)
            {
                if(line % 2 != d)
                {
                    if(line >= n)
                        difference++;
                    int i1 = line - difference;
                    int j1 = difference;
                    for (int i = 0; i < line + 1 - difference * 2; i++)
                    {
                        matrix[i1, j1] = ++num;
                        i1--;
                        j1++;
                    }
                }
                else
                {
                    if (line >= n)
                        difference++;
                    int i1 = difference;
                    int j1 = line - difference;
                    for (int i = 0; i < line + 1 - difference * 2; i++)
                    {
                        matrix[i1, j1] = ++num;
                        i1++;
                        j1--;
                    }
                }
                
            }
        }

        public override string ToString()
        {
            string str = "";
            for(int i = 0; i < n; i++)
            {
                for(int j=0; j < n; j++)
                {
                    str += matrix[i, j] + " ";
                }
                str += "\n";
            }
            return str;
        }

    }
}
