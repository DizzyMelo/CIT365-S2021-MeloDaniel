using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApplication
{
    class GlazerApp
    {
        public static void RunExample() 
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("========================= Glazer App =========================");
            
            Console.WriteLine("Enter the width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter the height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is {0} feet", woodLength);

            Console.WriteLine("The area of the glass is {0} square metres", glassArea);
        }
    }
}
