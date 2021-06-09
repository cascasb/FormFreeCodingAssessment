using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CheckTriangleValidity1()
        {
            bool test = FormFreeAssessment1.Program.CheckTriangleValidity(10, 1, 1);
            Assert.AreEqual(test, false);
        }

        [TestMethod]
        public void Test_CheckTriangleValidity2()
        {
            bool test = FormFreeAssessment1.Program.CheckTriangleValidity(3, 4, 5);
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckTriangleValidity3()
        {
            bool test = FormFreeAssessment1.Program.CheckTriangleValidity(0, 0, 0);
            Assert.AreEqual(test, false);
        }

        [TestMethod]
        public void Test_CheckTriangleValidity4()
        {
            bool test = FormFreeAssessment1.Program.CheckTriangleValidity(10, 10, 10);
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckTriangleValidity5()
        {
            bool test = FormFreeAssessment1.Program.CheckTriangleValidity(-10, 10, 10);
            Assert.AreEqual(test, false);
        }


        [TestMethod]
        public void Test_CheckForEquilateral1()
        {
            bool test = FormFreeAssessment1.Program.CheckForEquilateral(3, 4, 5);
            Assert.AreEqual(test, false);
        }

        [TestMethod]
        public void Test_CheckForEquilateral2()
        {
            bool test = FormFreeAssessment1.Program.CheckForEquilateral(5, 5, 5);
            Assert.AreEqual(test, true);
        }


        [TestMethod]
        public void Test_CheckForIsosceles1()
        {
            bool test = FormFreeAssessment1.Program.CheckForIsosceles(3, 4, 5);
            Assert.AreEqual(test, false);
        }

        [TestMethod]
        public void Test_CheckForIsosceles2()
        {
            bool test = FormFreeAssessment1.Program.CheckForIsosceles(4, 4, 5);
            Assert.AreEqual(test, true);
        }


        [TestMethod]
        public void Test_CheckForScalene1()
        {
            bool test = FormFreeAssessment1.Program.CheckForScalene(3, 4, 5);
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckForScalene2()
        {
            bool test = FormFreeAssessment1.Program.CheckForScalene(4, 4, 5);
            Assert.AreEqual(test, false);
        }


        [TestMethod]
        public void Test_CheckContinueInput1()
        {
            bool test = FormFreeAssessment1.Program.CheckContinueInput('y');
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckContinueInput2()
        {
            bool test = FormFreeAssessment1.Program.CheckContinueInput('Y');
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckContinueInput3()
        {
            bool test = FormFreeAssessment1.Program.CheckContinueInput('n');
            Assert.AreEqual(test, false);
        }

        [TestMethod]
        public void Test_CheckContinueInput4()
        {
            bool test = FormFreeAssessment1.Program.CheckContinueInput('N');
            Assert.AreEqual(test, false);
        }


        [TestMethod]
        public void Test_CheckValidInput1()
        {
            bool test = FormFreeAssessment1.Program.CheckValidInput("!");
            Assert.AreEqual(test, false);
        }

        [TestMethod]
        public void Test_CheckValidInput2()
        {
            bool test = FormFreeAssessment1.Program.CheckValidInput("Hello");
            Assert.AreEqual(test, false);
        }

        [TestMethod]
        public void Test_CheckValidInput3()
        {
            bool test = FormFreeAssessment1.Program.CheckValidInput("1");
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckValidInput4()
        {
            bool test = FormFreeAssessment1.Program.CheckValidInput("1.75");
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckValidInput5()
        {
            bool test = FormFreeAssessment1.Program.CheckValidInput("-1");
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckValidInput6()
        {
            bool test = FormFreeAssessment1.Program.CheckValidInput("-1.75");
            Assert.AreEqual(test, true);
        }

        [TestMethod]
        public void Test_CheckValidInput7()
        {
            bool test = FormFreeAssessment1.Program.CheckValidInput("0");
            Assert.AreEqual(test, true);
        }
    }
}
