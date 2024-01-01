using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    /// <summary>
    /// singly linked list
    /// </summary>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Firs element of list
        /// </summary>
        public Item<T> Head {get; private set;}
        /// <summary>
        /// Last element of lisr
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// Count of list elements
        /// </summary>
        public int Count { get; private set; }


        /// <summary>
        /// Create empty list
        /// </summary>
        public LinkedList()
        {
            Clear();

        }


   

        /// <summary>
        /// Create list with start elements
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {
            
            SetHeadAndTail(data);

        }


        /// <summary>
        /// Add elements to the end list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {

            if(Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }

        }

        /// <summary>
        /// Delete first written element in the list
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if(Head != null)
            {

                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previus = Head;



                while(current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previus.Next = current.Next;
                        Count--;
                        return;
                    }
                    previus = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Add data to the start of the list
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };
            
            Head = item;
            Count++;

        }

        public void InsertAfter(T target, T data)
        {

            if (Head != null)
            {
               
                var current = Head;
                while(current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
           
     
            }
            else
            {
                SetHeadAndTail(target);
                Add(data);
            }
        }

        /// <summary>
        /// Clear List
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;

            }
        }

        public override string ToString()
        {
            return "Linked List" + Count + "Elements";
        }


    }
}
