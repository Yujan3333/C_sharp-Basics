using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class WithoutUsingDelegate
    {
        public void ReturnSum(int a , int b)
        { 
            Console.WriteLine("Sum is {0}",a+b);
            
        }
        public void WelcomeMessage(string messages)
        {
            Console.WriteLine("Message is {0}",messages);
        }
        public void PrintingTheMessage()
        {
            Console.WriteLine("Enter 2 numbers You want to add::");
            int no1, no2;
            no1=int.Parse(Console.ReadLine());
            no2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the welcome message:: ");
            string welcomeMsg=Console.ReadLine();
            WithoutUsingDelegate instance1= new WithoutUsingDelegate();
            instance1.ReturnSum(no1, no2);
            instance1.WelcomeMessage(welcomeMsg);
        }

    }
}
