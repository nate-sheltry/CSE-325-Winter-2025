using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Nathaniel Dunham";
            string location = "Arizona";

            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I am from {location}.");
            DateTime curDate = DateTime.Now;
            DateTime christmas = new DateTime(curDate.Year, 12, 25);
            Console.WriteLine($"{curDate.Month:00}/{curDate.Day:00}/{curDate.Year}");

            int daysUntilChristmas = (christmas.Date - curDate.Date).Days;
            Console.WriteLine($"Days until Christmas: {daysUntilChristmas}");

            double width, height, woodLength, glassArea;
            string widthString, heightString;


            
            Console.Write("Glass Width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Glass Height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.ReadKey();
        }
    }
}
