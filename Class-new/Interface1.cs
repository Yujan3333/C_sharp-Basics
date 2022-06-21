using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_new
{
    //Ivariable_name is the naming convention for interface
    //Interface is the defination of the funcions.
    interface Ifruit
    {
        void eating();
        void riding();
    }
    interface Ivehicle
    {

        //void riding();
    }
    public class apple : Ifruit
    {
        public void eating()
        {
            Console.WriteLine("This is apple calling");
        }
        //void Ivehicle.riding()
        //{
        //    Console.WriteLine("This is riding Car with Ivehicle");
        //}
        void Ifruit.riding()
        {
            Console.WriteLine("This is riding Car with Ifruit");
        }




        public class banana : Ifruit
        {
            public void eating()
            {
                Console.WriteLine("\nThis is banana calling");
            }
            public void riding()
            {
                Console.WriteLine("I am riding a bike");
            }
        }
        internal interface Interface1
        {
        }
    }
}
