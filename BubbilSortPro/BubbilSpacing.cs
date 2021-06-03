using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbilSortPro
{
    public class BubbilSpacing:BubbilSort
    {
        public override void Sort(int[] arr)
        {
            // qo'chimcha code:

            base.Sort(arr);
        }
        public int[] AddArrayValue(int[] arry, int value)
        {
            int[] newArray = new int[arry.Length + 1];
            
            for (int i = 0; i < newArray.Length-1; i++)
            {
                newArray[i] = arry[i];
            }
            Console.WriteLine("Bubbil Spacing");
            newArray[arry.Length] = value;

            return newArray;
        }

    }
}
