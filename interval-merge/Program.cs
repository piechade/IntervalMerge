using System;
using System.Collections.Generic;

namespace interval_merge
{
    class Program
    {
        static void Main()
        {
            Interval[] intervals = new Interval[4];
            intervals.SetValue(new Interval(25, 30), 0);
            intervals.SetValue(new Interval(2, 19), 1);
            intervals.SetValue(new Interval(14, 23), 2);
            intervals.SetValue(new Interval(4, 8), 3);
            Merge(intervals);
        }

        private static void Merge(Interval[] intervals)
        {
            if (intervals.Length <= 0)
                return;

            // Creates and initializes a new Stack
            Stack<Interval> myStack = new Stack<Interval>();

            Array.Sort(intervals);

            myStack.Push(intervals[0]);

            for (int i = 1; i < intervals.Length; i++)
            {
                Interval top = myStack.Peek();

                if (top.End < intervals[i].Start)
                    myStack.Push(intervals[i]);

 
                else if (top.End < intervals[i].End)
                {
                    top.End = intervals[i].End;
                    myStack.Pop();
                    myStack.Push(top);
                }
            }

            Console.WriteLine("The Merged Intervals are: ");

            foreach (Interval interval in myStack)
                Console.Write("[{0},{1}] ", interval.Start, interval.End);
        }
    }
}
