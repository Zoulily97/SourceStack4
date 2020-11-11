namespace Csharp.其他
{
    public class DoubleLinked
    {
        public DoubleLinked Next { get; set; }
        public DoubleLinked Previous { get; set; }

        //在节点后插入节点node
        public void AddAfter(DoubleLinked node)
        {

            if (this.Next != null)
            {
                node.Next = this.Next;
                //  node.Previous = this;
                this.Next.Previous = node;
                //  this.Next = node;
            }

            node.Previous = this;
            this.Next = node;


        }

        //在节点前插入节点node
        public void InsretBefor(DoubleLinked node)
        {
            if (this.Previous != null)
            {
                node.Previous = this.Previous;
                this.Previous.Next = node;
            }
            node.Next = this;
            this.Previous = node;
        }

        //删除节点
        public void Delete()
        { //  1 2 【3】 4    1 2
            DoubleLinked oldPre = this.Previous;
            DoubleLinked oldNex = this.Next;
            if(oldPre != null)
            {
                oldPre.Next = this.Next;

            }
            if (oldNex != null)
            {
                oldNex.Previous = this.Previous;
            }
            this.Previous = this.Next = null;




            //if (this.Previous != null && this.Next != null)
            //{
            //    this.Previous.Next = this;
            //    this.Next.Previous = this;
            //}
            //else if (this.Previous == null)
            //{
            //   Next= Previous = null;
            //}
            //else
            //{
            //    Next = Previous = null;
            //}




        }


        //交换节点
        public void Swap(DoubleLinked targetNode)
        {
            //  1  2   3   4
            //   4  1  2  3  
            //   3   1  2   4 
            //this  targetNode

            //  1 2   2  1尾
            if (targetNode.Next == null)
            {
                if (this.Next == targetNode)
                {
                    targetNode.Next = this;
                    this.Next = null;
                    this.Previous = targetNode;

                }
            }
        }
    }
}
