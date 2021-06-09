using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_TenNodeIntegerList()
        {
            FreeFormAssessment2.Program.SinglyLinkedList intList = new FreeFormAssessment2.Program.SinglyLinkedList();
            for (int x = 0; x < 10; x++)
            {
                intList.Append(x + 1);
            }
            string test = intList.FindFifthFromEnd();
            Assert.AreEqual(test, "The fifth element form the end is: 6");
        }

        [TestMethod]
        public void Test_FiveNodeIntegerList()
        {
            FreeFormAssessment2.Program.SinglyLinkedList intList = new FreeFormAssessment2.Program.SinglyLinkedList();
            for (int x = 0; x < 5; x++)
            {
                intList.Append(x + 1);
            }
            string test = intList.FindFifthFromEnd();
            Assert.AreEqual(test, "The fifth element form the end is: 1");
        }

        [TestMethod]
        public void Test_ThreeNodeIntegerList()
        {
            FreeFormAssessment2.Program.SinglyLinkedList intList = new FreeFormAssessment2.Program.SinglyLinkedList();
            for (int x = 0; x < 3; x++)
            {
                intList.Append(x + 1);
            }
            string test = intList.FindFifthFromEnd();
            Assert.AreEqual(test, "The List was not 5 nodes long");
        }

        [TestMethod]
        public void Test_TenNodeStringList()
        {
            FreeFormAssessment2.Program.SinglyLinkedList stringList = new FreeFormAssessment2.Program.SinglyLinkedList();
            for (int x = 0; x < 10; x++)
            {
                stringList.Append("String" + (x + 1));
            }
            string test = stringList.FindFifthFromEnd();
            Assert.AreEqual(test, "The fifth element form the end is: String6");
        }

        [TestMethod]
        public void Test_FiveNodeStringList()
        {
            FreeFormAssessment2.Program.SinglyLinkedList stringList = new FreeFormAssessment2.Program.SinglyLinkedList();
            for (int x = 0; x < 5; x++)
            {
                stringList.Append("String" + (x + 1));
            }
            string test = stringList.FindFifthFromEnd();
            Assert.AreEqual(test, "The fifth element form the end is: String1");
        }

        [TestMethod]
        public void Test_ThreeNodeStringList()
        {
            FreeFormAssessment2.Program.SinglyLinkedList stringList = new FreeFormAssessment2.Program.SinglyLinkedList();
            for (int x = 0; x < 3; x++)
            {
                stringList.Append("String" + (x + 1));
            }
            string test = stringList.FindFifthFromEnd();
            Assert.AreEqual(test, "The List was not 5 nodes long");
        }

        [TestMethod]
        public void Test_EmptyList()
        {
            FreeFormAssessment2.Program.SinglyLinkedList emptyList = new FreeFormAssessment2.Program.SinglyLinkedList();
            string test = emptyList.FindFifthFromEnd();
            Assert.AreEqual(test, "The list is empty.");
        }
    }
}
