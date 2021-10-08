using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void BasicBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void OutOfSequenceReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void BracketsWithStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void BracketsBeforeStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        [TestMethod]
        public void BracketsWithinStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        [TestMethod]
        public void MultipleBracketsInSequence()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }

        [TestMethod]
        public void MultipleBracketsOutofSequence()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][]["));
        }

        [TestMethod]
        public void SingleBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void SingleBracketsWithinStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch[Code"));
        }

        [TestMethod]
        public void OutOfSequenceWithingString()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]Launch[Code"));
        }

        [TestMethod]
        public void MultipleBracketPairs()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][][]"));
        }

        [TestMethod]
        public void MultipleBracketPairsReturnsFalseOutofSequence()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]["));
        }

    }
}
