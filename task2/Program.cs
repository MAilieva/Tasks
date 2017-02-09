using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Type a Date that you are searching for(Format: month(in digits),day of the Month)");
            string[] input = Console.ReadLine().Split(',').ToArray();
            int day = int.Parse(input[1]);
            int month = int.Parse(input[0]);
            Console.WriteLine("Type a Date To begin with(Format: year,month,day)");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Type a Date To End with(Format: year,month,day)");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            int count = 0;

            for (DateTime dt = startDate; dt < endDate; dt = dt.AddDays(1.0))
            {
                if (dt.DayOfWeek == DayOfWeek.Wednesday && dt.Day == day && dt.Month == month)
                {

                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
