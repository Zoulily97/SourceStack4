using NUnit.Framework;
using Csharp;
using Csharp.其他;
using System.Security.Cryptography;

namespace NUnitTest
{
    public class DLinkNodesTests
    {
        private DoubleLinked node1, node2, node3, node4,node5,node6,node7;

        [SetUp]
        public void Setup()
        {
            /* DoubleLinked*/
            node1 = new DoubleLinked();
            /*DoubleLinked*/
            node2 = new DoubleLinked();
            /*DoubleLinked*/
            node3 = new DoubleLinked();
            /* DoubleLinked*/
            node4 = new DoubleLinked();
            node5 = new DoubleLinked();
            node6 = new DoubleLinked();
            node7 = new DoubleLinked();
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Previous = node6;
            node6.Previous = node5;
            node5.Previous = node4;
            node4.Previous = node3;
            node3.Previous = node2;
            node2.Previous = node1;

        }



        [Test]
        public void AddTest()
        {

            node1.AddAfter(node2);//把node2加在node1之后

            //1 [2]
            Assert.IsNull(node1.Previous);
            Assert.AreEqual(node2, node1.Next);
            Assert.AreEqual(node1, node2.Previous);
            // Assert.IsNull(node2.Next);
            // 1 2 [3]
            
            node2.AddAfter(node3);
            Assert.AreEqual(node3, node2.Next);
            Assert.AreEqual(node2, node3.Previous);
            //Assert.IsNull(node3.Next);

            //1 2  [4] 3
             
            node3.AddAfter(node4);
            Assert.AreEqual(node4, node3.Next);
            Assert.AreEqual(node3, node4.Previous);
            Assert.AreEqual(node4, node3.Next);
            Assert.AreEqual(node3, node4.Previous);
            //Assert.IsNull(node4.Next);

        }

        [Test]
        public void InsertBeforTest()
        {
            //1 2  [3] 4
            node4.InsretBefor(node3);
           // Assert.IsNull(node4.Next);
            Assert.AreEqual(node3, node4.Previous);
            Assert.AreEqual(node4, node3.Next);

            // [2] 3 4
            node3.InsretBefor(node2);

            Assert.AreEqual(node2, node3.Previous);
            Assert.AreEqual(node3, node2.Next);
            //2[1] 3 4
            node3.InsretBefor(node1);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node3, node1.Next);
            //  Assert.IsNull(node2.Previous);


        }
        
        [Test]
        public void DeleteTest()
        {
            // 1 2 3 4 5 6 7
            // 2 3 4 5 6 7

            node1.Delete();
            Assert.IsNull(node1.Next);
            Assert.IsNull(node2.Previous);
            // 1 2

          //  node2.Delete();
          ////  Assert.IsNull(node2.Previous.Next);
          //  //1 2 3 
          //  node2.Delete();
          //  Assert.AreEqual(node1, node3.Previous);
          //  Assert.AreEqual(node3, node1.Next);
          //  // 1 2 3 4
          //  node3.Delete();
          //  Assert.AreEqual(node4, node2.Next);
          //  Assert.AreEqual(node2, node4.Previous);

        }

        //[Test]
        //public void SwapTest()
        //{
        //    //头节点               【1】  【 2   3   4
        //    //2 1 3 4

        //    //node1.Swap(node2);
        //    //Assert.AreEqual(node2, node1.Previous);



        //    //尾节点、1 2 3 4        1 2 4 3
        //    node3.Swap(node4);
        //    Assert.AreEqual(node4, node3.Previous);
        //    Assert.AreEqual(node3, node4.Next);

        //    ////中间节点  1 2  3   4      3  2  1  4
        //    //node1.Swap(node3);
        //    //Assert.AreEqual(node3, node1.Previous.Previous);
        //    //Assert.AreEqual(node1, node3.Next.Next);


        //}
    }
}
