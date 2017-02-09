using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder theBiggestNumber = new StringBuilder();    
            var currentMax = 0;
            var globalMax = 0;
            string[] input = (Console.ReadLine().Split(',').ToArray());
            List<int> list = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                list.Add(int.Parse(input[i]));
            }

           while (list.Count!=1)
            {
                for (int i = 0; i < list.Count-1; i++)
                {

                    currentMax =biggerNumber(list[i],list[i+1]);

                    globalMax = biggerNumber(currentMax, globalMax);  
                  
                }
                theBiggestNumber.Append(globalMax);
                list.Remove(globalMax);
                globalMax = 0;
                currentMax = 0;
            }
            theBiggestNumber.Append(list[0]);
            Console.WriteLine(theBiggestNumber.ToString());
        }
        public static int biggerNumber(int num1, int num2)
        {
           var currentMax = 0;

            var str1 = num1.ToString();
            var str2 = num2.ToString();

            if (num1 >= num2 && str1.Length == str2.Length)
            {
                currentMax = num1;

            }
            else if (str1.Length < str2.Length && str1.Length < 2 && str2.Length <2  && str1[0] >= str2[0])
            {
                currentMax = num1;
            }
            else if (str1.Length < str2.Length && str1[0] > str2[0])
            {
                currentMax = num1;
            }
            else if ((str1.Length < str2.Length && str1.Length > 2 && str2.Length > 2 && str1[0] >= str2[0] && str1[1] >= str2[1] && str1[2] >= str2[2]))
            {
                currentMax = num1;
            }
 
            else if ((str1.Length > str2.Length &&str1[0] >= str2[0]))
            {
                currentMax = num1;
            }
            else
            {
                currentMax = num2;
            }
            return currentMax;
        }


       
    }
}
