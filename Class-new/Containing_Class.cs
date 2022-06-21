//Using new keyword in inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containing_Class
{
    class class1
    {
        public void fruit()
        {
            Console.WriteLine("This is Fruit");
        }
    }
    class class2 : class1
    {
        //creates a new instance totally not overriding completely new
        public new void fruit()
        {
            Console.WriteLine("This is orange");
            Console.WriteLine("All this is fine!!");
        }
    }

    internal class Class1
    {
    }
}
