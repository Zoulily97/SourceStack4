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
            node1 = new DoubleLinked() { value=1};
            /*DoubleLinked*/
            node2 = new DoubleLinked() { value = 2};
            /*DoubleLinked*/
            node3 = new DoubleLinked() { value = 3 };
            /* DoubleLinked*/
            node4 = new DoubleLinked() { value = 4 };
            node5 = new DoubleLinked() { value = 5 };
            node6 = new DoubleLinked() { value = 6 };
            //node7 = new DoubleLinked() { value = 7 };
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
           // node6.Next = node7;
          //  node7.Previous = node6;
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
            Assert.IsNull(node2.Previous);
            node3.Delete();
            Assert.AreEqual(node4, node2.Next);
            Assert.AreEqual(node2, node4.Previous);
          //  node7.Delete();
          //  Assert.IsNull(node6.Next);
        }

        [Test]
        public void SwapTest()
        {
            // //头节点               【1】  【 2   3   4
            // //2 1 3 4

            // node1.Swap(node2);
            // Assert.AreEqual(node2, node1.Previous);


            // //2134    2143

            // node3.Swap(node4);
            // Assert.AreEqual(node4, node3.Previous);
            // Assert.AreEqual(node3, node4.Next);

            //// 中间节点  2143       2  3  4  1
            // node1.Swap(node3);
            // Assert.AreEqual(node3, node1.Previous.Previous);
            // Assert.AreEqual(node1, node3.Next.Next);
            //   [1] 2 3 4 5 [6] 
            //=> [6] 2 3 4 5 [1]
            node1.Swap(node6);
            Assert.AreEqual(node2, node6.Next);
            Assert.AreEqual(node6, node2.Previous);
            Assert.IsNull(node6.Previous);
            Assert.AreEqual(node5, node1.Previous);
            Assert.AreEqual(node1, node5.Next);
            Assert.IsNull(node1.Next);


            //   [6] [2] 3 4 5 1
            // => [2] [6] 3 4 5 1
            node2.Swap(node6);
            Assert.AreEqual(node3, node6.Next);
            Assert.AreEqual(node2, node6.Previous);
            Assert.AreEqual(node6, node2.Next);
            Assert.AreEqual(node6, node3.Previous);
          Assert.IsNull(node2.Previous);


            //    2 6 3 4 [5] [1]
            // => 2 6 3 4 [1] [5]
            node5.Swap(node1);
            Assert.AreEqual(node5, node1.Next);
            Assert.AreEqual(node4, node1.Previous);
            Assert.AreEqual(node1, node5.Previous);
            Assert.AreEqual(node1, node4.Next);
            Assert.IsNull(node5.Next);


            //    [2] 6 [3] 4 1 5
            // => [3] 6 [2] 4 1 5 
            node2.Swap(node3);
            Assert.AreEqual(node4, node2.Next);
            Assert.AreEqual(node6, node2.Previous);
            Assert.AreEqual(node2, node6.Next);
            Assert.AreEqual(node3, node6.Previous);
            Assert.AreEqual(node6, node3.Next);
            Assert.AreEqual(node2, node4.Previous);
            Assert.IsNull(node3.Previous);


            //    3 6 2 [4] 1 [5]
            // => 3 6 2 [5] 1 [4]
            node4.Swap(node5);
            Assert.AreEqual(node1, node5.Next);
            Assert.AreEqual(node2, node5.Previous);
            Assert.AreEqual(node4, node1.Next);
            Assert.AreEqual(node5, node1.Previous);
            Assert.AreEqual(node1, node4.Previous);
            Assert.IsNull(node4.Next);
            Assert.AreEqual(node5, node2.Next);


            //    3 [6] [2] 5 1 4 
            // => 3 [2] [6] 5 1 4
            node6.Swap(node2);
            Assert.AreEqual(node5, node6.Next);
            Assert.AreEqual(node2, node6.Previous);
            Assert.AreEqual(node3, node2.Previous);
            Assert.AreEqual(node6, node2.Next);
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node6, node5.Previous);

            //    3 [2] 6 [5] 1 4 
            // => 3 [5] 6 [2] 1 4
            node2.Swap(node5);
            Assert.AreEqual(node6, node5.Next);
            Assert.AreEqual(node3, node5.Previous);
            Assert.AreEqual(node2, node6.Next);
            Assert.AreEqual(node5, node6.Previous);
            Assert.AreEqual(node6, node2.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node5, node3.Next);
            Assert.AreEqual(node4, node1.Next);


            //    [3] 5 6 2 1 [4]先
            // => [4] 5 6 2 1 [3]

            node4.Swap(node3);
            Assert.AreEqual(node4, node5.Previous);
            Assert.AreEqual(node5, node4.Next);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node3, node1.Next);
            Assert.IsNull(node3.Next);
            Assert.IsNull(node4.Previous);


            // 5先
            //    [4] [5] 6 2 1 3
            // => [5] [4] 6 2 1 3
            node5.Swap(node4);
            Assert.AreEqual(node6, node4.Next);
            Assert.AreEqual(node5, node4.Previous);
            Assert.AreEqual(node4, node5.Next);
            Assert.AreEqual(node4, node6.Previous);
          Assert.IsNull(node5.Previous);


            //  3先
            //    5 4 6 2 [1] [3]
            // => 5 4 6 2 [3] [1]
            node3.Swap(node1);
            Assert.AreEqual(node1, node3.Next);
            Assert.AreEqual(node2, node3.Previous);
            Assert.AreEqual(node3, node1.Previous);
            Assert.AreEqual(node3, node2.Next);
            Assert.IsNull(node1.Next);


            // 6先
            //    [5] 4 [6] 2 3 1 
            // => [6] 4 [5] 2 3 1
            node6.Swap(node5);
            Assert.AreEqual(node5, node4.Next);
            Assert.AreEqual(node6, node4.Previous);
            Assert.AreEqual(node2, node5.Next);
            Assert.AreEqual(node4, node5.Previous);
            Assert.AreEqual(node4, node6.Next);
            Assert.AreEqual(node5, node2.Previous);
            Assert.IsNull(node6.Previous);


            // 1先
            //    6 4 5 [2] 3 [1]
            // => 6 4 5 [1] 3 [2]
            node1.Swap(node2);
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node3, node1.Next);
            Assert.AreEqual(node5, node1.Previous);
            Assert.AreEqual(node3, node2.Previous);
            Assert.IsNull(node2.Next);
            Assert.AreEqual(node1, node5.Next);



        }






        [Test]
        public void BinarySeekTest()
        {
            int[] array =  { 1, 2, 3, 4, 5, 8, 9 };
            Assert.AreEqual(0, SomeArray<int>.BinarySeek(array, 1));
            Assert.AreEqual(6, SomeArray<int>.BinarySeek(array, 9));
            Assert.AreEqual(5, SomeArray<int>.BinarySeek(array, 8));
            Assert.AreEqual(3, SomeArray<int>.BinarySeek(array, 4));
            Assert.AreEqual(1, SomeArray<int>.BinarySeek(array, 2));
           
        }
    }
}
