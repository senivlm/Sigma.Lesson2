using System;

namespace Lesson2
{
    internal class Vector
    {
        /// <summary>
        /// Наш масив
        /// </summary>
        private int[] array;

        /// <summary>
        /// Сетер
        /// </summary>
        public int[] Array { set { array = value;} }

        public int this[int index]
        {
            get 
            { 
                if(index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    throw new Exception("Index out of range array");
                }
            }
            set
            {
                array[index] = value;
            }

        }

        public Vector(int[] arr) { this.array = arr; }
        public Vector(int n)
        {
            array = new int[n];
        }
        public Vector() { }

        /// <summary>
        /// Генерація масиву в заданому діапазоні
        /// </summary>
        /// <param name="a">Перша границя</param>
        /// <param name="b">Друга границя</param>
        public void InitRand(int a, int b)
        {
            Random r = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(a, b);
            }
        }

        /// <summary>
        /// Перевірка масиву, чи є він паліндромом
        /// </summary>
        /// <returns>Булеве значення</returns>
        public bool IsPalindrom()
        {
            int mid = array.Length / 2;
            int left, right;
            if (mid % 2 == 1)
            {
                right = mid + 1;
                left = mid - 1;
            }
            else
            {
                right = mid;
                left = right - 1;
            }
            for(int i = 1;right < array.Length; i++)
            {
                if (array[right] != array[left])
                {
                    return false;
                }
                right += i;
                left -= i;
            }
            return true;
        }

        /// <summary>
        /// Реверс масива
        /// </summary>
        public void Reverse()
        {
            int[] copy = new int[array.Length];
            for(int i = array.Length - 1, ind = 0; i >= 0; i--, ind++)
            {
                copy[ind] = array[i];
            }
            array = copy;
        }

        /// <summary>
        /// Генерація масиву з числами, що не повторюються (ОПТИМІЗОВАНО)
        /// </summary>
        public void InitShuffle()
        {
            Random random = new Random();
            int[] masOfExists = new int[array.Length];
            int x;
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    x = random.Next(1, array.Length + 1);
                    if (masOfExists[x - 1] == 0) 
                    {
                        masOfExists[x - 1] = x;
                        array[i] = x;
                        break;
                    } 
                }
                    
            }
            
        }

        /// <summary>
        /// Виводить максимальний підмасив з однаковими числами
        /// </summary>
        /// <returns></returns>
        public string GetMaxSequence()
        {
            Vector mas;
            int start = 0;
            int end = 0;
            int max = 0;
            int value = 0;
            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    start = i;
                    for(int j = start; j < array.Length; j++)
                    {
                        if(array[j+1] != array[start])
                        {
                            end = j + 1;
                            break;
                        }
                    }

                }
                catch
                {
                    end = array.Length;
                }
                if(end - start > max)
                {
                    max = end - start;
                    value = array[i];
                }
            }
            mas = new Vector(max);
            int[] masCopy = new int[max];
            for(int i = 0; i < max; i++)
            {
                masCopy[i] = value;
            }
            mas.Array = masCopy;
            return mas.ToString();
        }

        /// <summary>
        /// Знаходить частоту чисел в масиві
        /// </summary>
        /// <returns></returns>
        public Pair[] CalculateFreq()
        {
            Pair[] pairs = new Pair[array.Length];

            for(int i = 0; i < array.Length; i++)
            {
                pairs[i] = new Pair(0, 0);
            }

            int countDifference = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isElement = false;
                for(int j = 0; j < countDifference; j++)
                {
                    if(array[i] == pairs[j].Number)
                    {
                        pairs[j].Freq++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countDifference].Freq++;
                    pairs[countDifference].Number = array[i];
                    countDifference++;
                }
            }

            Pair[] result = new Pair[countDifference];
            for(int i = 0;i < countDifference; i++)
            {
                result[i] = pairs[i];
            }

            return result;
        }

        /// <summary>
        /// Повертає масив
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string line = "";
            for(int i = 0; i < array.Length; i++)
            {
                line += array[i] + " ";
            }
            return line;
        }
    }
}
