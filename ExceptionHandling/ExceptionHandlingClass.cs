using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    static class ExceptionHandlingClass
    {
        public static void Divide_ByZero_Exception()
        {
            //int a = 2;
            ////int b = 0;
            
            try
            {
                //string b = "ahdld";
                //int c = int.Parse(b);
                //int div = a / c;
                int[] values = null;
                foreach (var i in values)
                {
                    Console.WriteLine(i);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error!!!");
            }
            finally
            {
                Console.WriteLine("Finally This always Runs");
            }
        }
    }
}
  