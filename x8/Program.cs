using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x8
{
    class Program
    {    
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(',').ToArray();
            char[] word = input[0].ToCharArray();
            int width = int.Parse(input[1]);
            int height = int.Parse(input[2]);
            int cols = word.Length + ((width - 1) * (word.Length - 1));
            int rows= word.Length + ((height - 1) * (word.Length - 1));
            int lastindex = word.Length - 1;
            for (int i = 0; i <rows ; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < cols; j++)
                {
                    

                    if (i % lastindex == 0  || j%lastindex==0)
                    {
                        if ((i + j) % (lastindex*2) <= lastindex)
                        {
                            Console.Write(word[(j+i) % (lastindex*2)]);
                        }
                        else
                        {
                            Console.Write(word[lastindex*2 - ((i + j) % (lastindex*2))]);
                        }
                    }
                    else Console.Write(" ");

                }

            }

        }
    }
}
