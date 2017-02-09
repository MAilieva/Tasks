using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',').ToArray();
            int temp = 0;
            List<int> list = new List<int>();
            int[] myInts = Array.ConvertAll(input, s => int.Parse(s));
            
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    var digit1 = int.Parse(input[i]);
                    var digit2 = int.Parse(input[j]);
                    if (digit1 > digit2)
                    {
                        temp = myInts[i];
                        myInts[i] = myInts[j];
                        myInts[j] = temp;
                    }

                }
            }
            for (int j = 0; j < input.Length; ++j)
            {
                list.Add(myInts[j]);
            }
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i]==list[i+1])
                {
                    Console.WriteLine("{0} Repeats",list[i]);
                    break;
                }
                else if (list[i]+1!=list[i+1])
                {
                    Console.WriteLine("{0} is missing", list[i]+1);
                    break;
                }
                else
                {
                    Console.WriteLine("The given array is consecutive and non repeating");
                }
            }

        }
    }
    }
