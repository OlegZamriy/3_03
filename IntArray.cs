using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_03
{
    using System;

    using System;

    public class IntArray : ISort
    {
        private int[] elements;

        public IntArray(int[] elements)
        {
            this.elements = elements;
        }

        public void Show()
        {
            Console.WriteLine("Array elements:");
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }

        public void Show(string info)
        {
            Console.WriteLine($"Array elements ({info}):");
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }

 
        public void SortAsc()
        {
            Array.Sort(elements);
        }

        public void SortDesc()
        {
            Array.Sort(elements);
            Array.Reverse(elements);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }

}


