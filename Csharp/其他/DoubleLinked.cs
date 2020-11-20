using System;
using System.Collections;
using System.Collections.Generic;

namespace Csharp.其他
{
    //用泛型改造二分查找、堆栈和双向链表
    public class DoubleLinked<T> : IEnumerable<DoubleLinked<T>>
    {
        public int value;
        public DoubleLinked<T> Next { get; set; }
        public DoubleLinked<T> Previous { get; set; }

        //在节点后插入节点node
        public void AddAfter(DoubleLinked<T> node)
        {
            //1 2] 3 4
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

        //在该节点前插入节点node
        public void InsretBefor(DoubleLinked<T> node)
        {
            if (this.Previous != null)
            {
                node.Previous = this.Previous;
                this.Previous.Next = node;
            }
            node.Next = this;
            this.Previous = node;
        }

        //删除当前节点
        public void Delete()
        { //  1 2- 【3】
            DoubleLinked<T> oldPre = this.Previous;
            DoubleLinked<T> oldNex = this.Next;
            if (oldPre != null)
            {
                oldPre.Next = oldNex;

            }
            if (oldNex != null)
            {
                oldNex.Previous = oldPre;
            }
            this.Previous = this.Next = null;

        }
        //交换节点
        public void Swap(DoubleLinked<T> targetNode)
        {

            DoubleLinked<T> prethis = this.Previous;
            DoubleLinked<T> nextthis = this.Next;
            this.Delete();
            if (nextthis == targetNode)
            {
                targetNode.AddAfter(this);
            }
            else if (prethis == targetNode)
            {
                targetNode.InsretBefor(this);
            }
            else /*if (nextthis != targetNode && prethis != targetNode)*/
            {
                targetNode.AddAfter(this);
                targetNode.Delete();
                if (prethis == null)
                {
                    nextthis.InsretBefor(targetNode);
                }
                else
                {
                    prethis.AddAfter(targetNode);

                }
            }








        }


        public DoubleLinked<T> FirstDlink()
        {
            DoubleLinked<T> Head = this;


            while (Head.Previous != null)
            {
                Head = Head.Previous;
            }
            return Head;
        }

        public IEnumerator<DoubleLinked<T>> GetEnumerator()
        {
            //throw new NotImplementedException();//IEnumerator<DoubleLinked<T>>的实现类
            return new Enumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()//显示实现接口的方法，通过接口类型变量调用
        {
            return GetEnumerator();//在做递归，
        }
    }



    struct Enumerator<T> : IEnumerator<DoubleLinked<T>>
    {
        private DoubleLinked<T> _current;
        private DoubleLinked<T> _index;
        public DoubleLinked<T> FirstDlink;
        public DoubleLinked<T> ThisDlink;
        public Enumerator(DoubleLinked<T> node)
        {
            _index = node;
            _current = _index;
            ThisDlink = node;
            FirstDlink = node.FirstDlink();

        }

        public DoubleLinked<T> Current => _current;

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (_index != null)
            {
                _current = _index;
                _index = _index.Next;

                return true;
            }
            else
            {


                if (FirstDlink == ThisDlink)
                {
                    return false;

                }

                _current = FirstDlink;
                FirstDlink = FirstDlink.Next; ;

                return true;
            }
        }
        public void Reset()
        {
            throw new NotImplementedException();
        }
    }




    public static class ExtensionMethod
    {
        ////调用扩展方法Max()：能够返回之前双向链表中存贮着最大值的节点
        public static DoubleLinked<T> Max<T>(this DoubleLinked<T> doubleLinked, DoubleLinked<T> linked) where T : IComparable
        {
            DoubleLinked<T> node =linked.FirstDlink();
            
            

            return node;
        }

    }

}
