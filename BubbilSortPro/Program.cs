using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbilSortPro
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arry=new int[]{12,32,3,5,8,0,1,34,45,4};
            BubbilPush bubbil = new BubbilPush();
            bubbil.Sort(arry);
            int[] newArray=bubbil.AddArrayValue(arry, 23);
            Console.WriteLine("Pufakcha saralash");
            bubbil.Sort(newArray);
            Console.WriteLine("Pufakcha surish saralash usuli");
            bubbil.InsertionSort(newArray);
            Console.ReadKey();
        }
    }
}
