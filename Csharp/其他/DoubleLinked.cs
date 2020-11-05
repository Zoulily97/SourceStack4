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
        public void InsertBefor(DoubleLinked node)
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
        public void Delete(DoubleLinked node)
        { //  1 2 【3】 4
            if (this.Previous != null)
            {
                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;
            }
            node.Next = node.Next;
            this.Previous = null;


        }
    }
}
