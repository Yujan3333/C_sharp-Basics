using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class GenericDelegate
    {
        public int ReturnSum(int a, int b)
        { 
            return  a+b;

        }
        public void WelcomeMessage(string messages)
        {
            Console.WriteLine("Message is {0}", messages);
        }
        public bool CheckOddNum(int no)
        {
            if (no % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintingTheMessage()
        {
            //With Parameter using Func
            Func<int, int, int> d1 = new Func<int, int, int>(ReturnSum);
            int res1 = d1.Invoke(15, 5);
            Console.WriteLine("Sum is:{0}", res1);

            //With no parameter using Action
            Action<string> d2 = new Action<string>(WelcomeMessage);
            d2.Invoke("Welcome Yujan");

            //Boolean result return using Predicate
            Predicate<int> d3 = new Predicate<int>(CheckOddNum);
            bool res2 = d3.Invoke(5);
            if(res2)
            {
                Console.WriteLine("Odd Number");
            }
            else
            {
                Console.WriteLine("Even Number");
            }
        }
    }
}
