using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1402lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(5,4,1,6,4);
            Console.WriteLine(arr.Avg());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Search(9));
            arr.SortByParam(false);
            arr.Show();
            Console.WriteLine();
            arr.SortAsc();
            arr.Show();
            Console.WriteLine();
            arr.SortDesc();
            arr.Show();
        }
    }
}
