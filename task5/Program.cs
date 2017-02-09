using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',').ToArray();
            int[] myInts = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                myInts[i] = int.Parse(input[i]);
            }
            List<int> list = new List<int>();
            for (int i = 1; i < myInts.Length-1; i++)
            {
                if (myInts[i]>=myInts[i-1]&&myInts[i]>=myInts[i+1])
                {
                    list.Add(myInts[i]);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0}, ",list[i]);
            }
        }
    }
}
