using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{


    class Sort
    {
        public void MergeSort(ref int [] array,int left,int right)
        {
            if (left == right) return; 
            int mid = (left + right) / 2;
            MergeSort(ref array, left, mid);
            MergeSort(ref array, mid+1, right);
            int[] temp = new int[right - left + 1];

            int i = left, j = mid + 1,k=0;
            while(i<=mid&&j<=right)
            {
                if (array[i] < array[j]) { temp[k++] = array[i]; i++; }
                else { temp[k++] = array[j]; j++; }
                
            }
            while(i <= mid) temp[k++] = array[i++];
            while (j <= right) temp[k++] = array[j++];
            for(int x = left,y=0; x <=right;x++,y++)
            {
                array[x] = temp[y];
            }
        }


    }
    class Program
    {


        static void Main(string[] args)
        {
            int[] a = { 9, 4, 5, 6, 7, 3, 4, 5, 6 };
            foreach (int item in a)
            { Console.Write(item+" "); }
            Sort sortfun = new Sort();
            Console.Write("\n");
            sortfun.MergeSort(ref a, 0, 8);
            foreach (int item in a)
            { Console.Write(item + " "); }
            Console.ReadKey();
        }
    }


}
