using System;
using System.Collections.Generic;

namespace IntervalMerge
{
    public class Program
    {
        public static void Main()
        {
            Interval[] intervals = { new Interval(25, 30), new Interval(2, 19), new Interval(14, 23), new Interval(4, 8) };

            Interval[] myStack = Merge(intervals);

            // Print contents of stack 
            Console.WriteLine("The Merged Intervals are: ");
            foreach (Interval interval in myStack)
            {
                Console.Write("[{0},{1}] ", interval.Start, interval.End);
            }
        }

        public static Interval[] Merge(Interval[] intervals)
        {
            // Test if the given set has at least one interval 
            if (intervals.Length <= 0)
                return null;

            // Creates and initializes a new Stack
            Stack<Interval> myStack = new Stack<Interval>();

            // Sort the intervals in increasing order of start time 
            Array.Sort(intervals);

            // Push the first interval to stack 
            myStack.Push(intervals[0]);

            // Start from the next interval and merge if necessary  
            for (int i = 1; i < intervals.Length; i++)
            {
                // Get interval from stack top 
                Interval top = myStack.Peek();

                // If current interval is not overlapping with stack top,  
                // Push it to the stack 
                if (top.End < intervals[i].Start)
                    myStack.Push(intervals[i]);

                // Otherwise update the ending time of top if ending of current  
                // interval is more 
                else if (top.End < intervals[i].End)
                {
                    top.End = intervals[i].End;
                    myStack.Pop();
                    myStack.Push(top);
                }
            }

            // Convert stack back to array
            Interval[] result = myStack.ToArray();

            // Sort the intervals in increasing order of start time 
            Array.Sort(result);

            return result;
        }
    }
}
