using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            byte tickets = Convert.ToByte(Console.ReadLine());

            bool qualified = age > 15 && dui == false && tickets <= 3;
            Console.WriteLine("Qualified?\r\n" + qualified);
            Console.ReadLine();
        }
    }
}
