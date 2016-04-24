using Edulinq.UnitTests.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Edulinq.UnitTests
{
    [TestClass]
    public class WhereUnitTests
    {
        [TestMethod]
        public void SimpleFiltering()
        {
            int[] source = { 1, 3, 4, 2, 8, 1 };
            var result = source.Where(x => x < 4);
            result.AssertSequenceEqual(1, 3, 2, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullSourceThrowsNullArgumentException()
        {
            IEnumerable<int> source = null;
            source.Where(x => x > 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullPredicateThrowsNullArgumentException()
        {
            int[] source = { 1, 3, 7, 9, 10 };
            Func<int, bool> predicate = null;
            source.Where(predicate);
        }
    }
}
