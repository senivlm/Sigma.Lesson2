using System;

namespace Lesson2
{
    internal class Pair
    {
        private int number;
        private int freq;

        public Pair(int number, int freg)
        {
            this.Number = number;
            this.Freq = freg;
        }

        public int Number { get => number; set => number = value; }
        public int Freq { get => freq; set => freq = value; }
        public override string ToString()
        {
            return $"{number} - {freq}";
        }
        public override bool Equals(object obj)
        {
            if(obj == null || this == null)
            {
                return false;
            }
            if(!(obj is Pair))
            {
                return false;
            }
            return (Number == ((Pair)obj).Number) && (Freq == ((Pair)obj).Freq);
        }
    }
}
