using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Edulinq.UnitTests.Infrastructure
{
    /// This is originally from MoreLINQ.
    public static class TestExtensions
    {

        public static void AssertSequenceEqual<T>(this IEnumerable<T> actual, params T[] expected)
        {
            List<T> copy = new List<T>(actual);
            Assert.AreEqual(expected.Length, copy.Count, "Expected counts to be equal");

            for (int i = 0; i < copy.Count; i++)
            {
                if (!EqualityComparer<T>.Default.Equals(expected[i], copy[i]))
                {
                    Assert.Fail("Expected sequences differ at index " + i + ": expected " + expected[i]
                        + "; was " + copy[i]);
                }
            }
        }
    }
}
