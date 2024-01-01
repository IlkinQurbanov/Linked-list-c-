

using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace LinkedList.Model
{
    /// <summary>
    /// list cell
    /// </summary>
    public class Item<T> 
    {

        /// <summary>
        /// Data stored in a list cell
        /// </summary>
        private T data = default(T);
        //private Item<T> next = null;

        public T Data
        {
            //get { return data; }
            //set
            //{
            //    if (value != null)
            //        data = value;
            //}

            get => data;
            set { 
                if (value != null) 
                    data = value;
                else 
                    throw new ArgumentNullException(nameof(value)); 
            }


        }


        /// <summary>
        /// next list cell
        /// </summary>
        public Item<T> Next { get; set; }

        //public Item<T> Next
        //{
        //    get
        //    {
        //        return Next1;
        //    }
        //    set
        //    {
        //        Next1 = value;
        //    }


        //}

       // private Item<T> Next1 { get => next; set => next = value; }


        public Item (T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    
    }
}
