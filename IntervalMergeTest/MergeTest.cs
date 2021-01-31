using IntervalMerge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace IntervalMergeTest
{
    [TestClass]
    public class MergeTest
    {
        [TestMethod]
        public void MergeMethodTest()
        {
            Interval[] input = { new Interval(25, 30), new Interval(2, 19), new Interval(14, 23), new Interval(4, 8) };
            Interval[] output = { new Interval(2, 23), new Interval(25, 30) };

            Interval[] result = IntervalMerge.Program.Merge(input);

            CollectionAssert.AreEqual(result, output, StructuralComparisons.StructuralComparer);
        }
    }
}
