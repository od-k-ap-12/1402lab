using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1402lab
{
    class MyArray:ISort,IMath,IOutput
    {
        int[] arr;
        public MyArray()
        {
            arr = new int[10];
        }
        public MyArray(params int[] b)
        {
            arr = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
                arr[i] = b[i];
        }
        public MyArray(int size)
        {
            arr = new int[size];
        }
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new Exception("Invalid index");
                }
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                {
                    arr[index] = value;
                }
                else
                {
                    throw new Exception("Invalid index");
                }
            }
        }

        public string Info { get; set; }

        public float Avg()
        {
            return (float)Queryable.Average(arr.AsQueryable());
        }

        public int Max()
        {
            return arr.Max();
        }

        public int Min()
        {
            return arr.Min();
        }

        public bool Search(int valueToSearch)
        {
            if(Array.BinarySearch(arr, valueToSearch) < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Show()
        {
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
        }

        public void SortAsc()
        {
            Array.Sort(arr);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void SortDesc()
        {
            SortAsc();
            Array.Reverse(arr);
        }
    }
}
