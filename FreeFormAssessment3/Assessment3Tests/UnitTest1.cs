using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment3Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CheckForPrimeNumber1()
        {
            bool test = FreeFormAssessment3.Program.checkForPrimeNumber(0);
            Assert.AreEqual(test, false);
        }

        [TestMethod]
        public void Test_CheckForPrimeNumber2()
        {
            bool test = FreeFormAssessment3.Program.checkForPrimeNumber(1);
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckForPrimeNumber3()
        {
            bool test = FreeFormAssessment3.Program.checkForPrimeNumber(2);
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckForPrimeNumber4()
        {
            bool test = FreeFormAssessment3.Program.checkForPrimeNumber(7);
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckForPrimeNumber5()
        {
            bool test = FreeFormAssessment3.Program.checkForPrimeNumber(10);
            Assert.AreEqual(test, false);
        }

        [TestMethod]
        public void Test_FindNextPrimeNumber1()
        {
            int test = FreeFormAssessment3.Program.FindNextPrimeNumber(2);
            Assert.AreEqual(test, 3);
        }

        [TestMethod]
        public void Test_FindNextPrimeNumber2()
        {
            int test = FreeFormAssessment3.Program.FindNextPrimeNumber(90);
            Assert.AreEqual(test, 97);
        }

        [TestMethod]
        public void Test_FindNextPrimeFactorization1()
        {
            string test = FreeFormAssessment3.Program.FindPrimeFactorization(1);
            Assert.AreEqual(test, "1");
        }

        [TestMethod]
        public void Test_FindNextPrimeFactorization2()
        {
            string test = FreeFormAssessment3.Program.FindPrimeFactorization(10);
            Assert.AreEqual(test, "2, 5");
        }

        [TestMethod]
        public void Test_FindNextPrimeFactorization3()
        {
            string test = FreeFormAssessment3.Program.FindPrimeFactorization(100);
            Assert.AreEqual(test, "2, 2, 5, 5");
        }

        [TestMethod]
        public void Test_CheckYesNoInput1()
        {
            bool test = FreeFormAssessment3.Program.CheckYesNoInput('Y');
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckYesNoInput2()
        {
            bool test = FreeFormAssessment3.Program.CheckYesNoInput('y');
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckYesNoInput3()
        {
            bool test = FreeFormAssessment3.Program.CheckYesNoInput('N');
            Assert.AreEqual(test, false);
        }

        [TestMethod]
        public void Test_CheckYesNoInput4()
        {
            bool test = FreeFormAssessment3.Program.CheckYesNoInput('n');
            Assert.AreEqual(test, false);
        }
    }
}
