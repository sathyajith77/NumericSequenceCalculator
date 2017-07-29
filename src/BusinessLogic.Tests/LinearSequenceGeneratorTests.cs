using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Tests
{
    [TestFixture]
    public class LinearSequenceGeneratorTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void SequenceGenerator_ShouldGenerateNextItem_WhenCalled(int input)
        {
            // Arrange
            var sequenceGenerator = new LinearSequenceGenerator();

            // Act
            int result = sequenceGenerator.GenerateNext(input);
            int expected = input + 1;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]       
        public void SequenceGenerator_ShouldNotGenerateSequence_WhenCalledWithNegativeInput()
        {
            // Arrange
            var sequenceGenerator = new LinearSequenceGenerator();

            // Act
            TestDelegate testAct = () =>
            {
                int result = sequenceGenerator.GenerateNext(-1);
            };

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(testAct);
        }

    }
}
