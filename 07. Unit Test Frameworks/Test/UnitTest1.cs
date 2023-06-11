using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainProgram;


namespace MainProgram.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestConvertToBase()
        {
            // Arrange
            int num = 12345;
            int newBase = 16;
            string expected = "3039";

            // Act
            string actual = Program.ConvertToBase(num, newBase);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountMaxUnequal()
        {
            // Arrange
            string str = "abbcccddddeeeee";
            int expected = 4;

            // Act
            int actual = Program.CountMaxUnequal(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountMaxConsecutive_Alpha()
        {
            // Arrange
            string str = "AAAbcDDDEFghiiii";
            int expected = 3;

            // Act
            int actual = Program.CountMaxConsecutive(str, Program.CharType.Alpha);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountMaxConsecutive_Digit()
        {
            // Arrange
            string str = "1234444555556666";
            int expected = 5;

            // Act
            int actual = Program.CountMaxConsecutive(str, Program.CharType.Digit);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
