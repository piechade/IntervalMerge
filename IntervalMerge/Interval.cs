using System;
using System.Collections.Generic;
using System.Text;

namespace IntervalMerge
{
    public class Interval: IComparable
    {
        public Interval(int start, int end)
        {
            this.Start = start;
            this.End = end;
            this.Valided();
        }


        public int Start { get; set; }

        public int End { get; set; }

        public void Valided()
        {
            if (this.Start >= this.End)
            {
                throw new ArgumentException("Object is not a Interval");
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is Interval)
            {
                return this.Start - (obj as Interval).Start;
            }
            throw new ArgumentException("Object is not a Interval");
        }
    }
}
