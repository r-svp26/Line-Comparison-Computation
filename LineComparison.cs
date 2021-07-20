using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonComputation
{
    class LineComparison
    {
        /// <summary>
        /// This method is used to check two lines are equal or not.
        /// </summary>
        public void length() 
        {
            // variables
            double pointX1;
            double pointY1;
            double pointX2;
            double pointY2;
            double pointX3;
            double pointY3;
            double pointX4;
            double pointY4;
            double distance1;
            double distance2;

            Console.WriteLine("Enter the first line co-ordinates");
            pointX1 = Convert.ToDouble(Console.ReadLine());
            pointY1 = Convert.ToDouble(Console.ReadLine());
            pointX2 = Convert.ToDouble(Console.ReadLine());
            pointY2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second line co-ordinates");
            pointX3 = Convert.ToDouble(Console.ReadLine());
            pointY3 = Convert.ToDouble(Console.ReadLine());
            pointX4 = Convert.ToDouble(Console.ReadLine());
            pointY4 = Convert.ToDouble(Console.ReadLine());

            // length of first line
            distance1 = Math.Sqrt((pointX2 - pointX1) * (pointX2 - pointX1) + (pointY2 - pointY1) * (pointY2 - pointY1));
            Console.WriteLine("Length of a line:" +distance1);
            // length of first line
            distance2 = Math.Sqrt((pointX4 - pointX3) * (pointX4 - pointX3) + (pointY4 - pointY3) * (pointY4 - pointY3));
            Console.WriteLine("Length of a line:" + distance2);

            // compare two lines
            if (distance1.Equals(distance2))
                Console.WriteLine("Both the lines are equal.");
            else
                Console.WriteLine("Both the lines are not equal.");
        }
    }
}
