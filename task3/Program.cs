using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',').ToArray();
            int[] myInts = Array.ConvertAll(input, s => int.Parse(s));
            int FirstMax = 0;
            int seccondMax=0;
            int thirdMax = 0;
            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            
            for (int i = 0; i < myInts.Length; i++)
            {
                if (FirstMax < myInts[i])
                {
                    FirstMax = myInts[i];
                    index1 = i;
                    
                }
         
            }
            for (int i = 0; i < myInts.Length; i++)
            {
                if (seccondMax < myInts[i] && myInts[i]!=FirstMax)
                {
                    seccondMax = myInts[i];
                    index2 = i;
                }

            }
            for (int i = 0; i < myInts.Length; i++)
            {
                if (thirdMax < myInts[i] && myInts[i] != seccondMax && myInts[i] != FirstMax)
                {
                    thirdMax = myInts[i];
                    index3 = i;
                }

            }
            int[] arr = { index1, index2, index3 };

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]>arr[i+1])
                {
                    int tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                }
            }
            Console.WriteLine("The nmbers are {0},{1},{2}",myInts[arr[0]],myInts[arr[1]],myInts[arr[2]]);
        }

    }
}
