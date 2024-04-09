using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_03
{
    using System;

    public class IntArray : IOutput, IMath
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

        public int Max()
        {
            int max = elements[0];
            foreach (var element in elements)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = elements[0];
            foreach (var element in elements)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach (var element in elements)
            {
                sum += element;
            }
            return (float)sum / elements.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (var element in elements)
            {
                if (element == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
