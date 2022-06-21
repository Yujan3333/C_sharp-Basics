using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void SumDelegate(int a, int b);
    public delegate void WelcomeDelegate(string message);
    public delegate void RectangleAreaDelegate(int l, int b);
    public delegate void RectanglePerimeterDelegate(int l, int b);
    class WithUsingDelegate
    {
        public void ReturnSum(int a, int b)
        {
            Console.WriteLine("Sum is {0}", a + b);

        }
        public void WelcomeMessage(string messages)
        {
            Console.WriteLine("Message is {0}", messages);
        }
        public void RectangleArea(int l , int b)
        {
            Console.WriteLine("\n Rectangle Area :: {0}",l*b);
        }
        public void RectanglePerimeter(int l, int b)
        {
            Console.WriteLine("Perimeter is : {0}",2*(l+b));
        }

        public void PrintingTheMessage()
        {
            //SumDelegate d1= new SumDelegate(ReturnSum);
            //d1.Invoke(5, 6);
            //WelcomeDelegate d2 = new WelcomeDelegate(WelcomeMessage);
            //d2.Invoke("Welcome");

            //For calculating the area of rectangle
            RectangleAreaDelegate area = new RectangleAreaDelegate(RectangleArea);
            area += ReturnSum;
            area += RectanglePerimeter;
            area.Invoke(5, 5);
            //Here removing the unwanted function that is being pointed by delegate
            area -= ReturnSum;
            area.Invoke(6, 6);
        }
    }
}
