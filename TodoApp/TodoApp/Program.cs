using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command Line Todo application");
            try
            {
                var ctrl = new Control();
                ctrl.Controller(args);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("there is a problem with you");
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("invalid input");
            }

        }
    }
}
