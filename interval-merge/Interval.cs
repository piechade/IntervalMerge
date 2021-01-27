using System;
using System.Collections.Generic;
using System.Text;

namespace interval_merge
{
    class Interval: IComparable
    {
        public Interval(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }


        public int Start { get; set; }

        public int End { get; set; }

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
