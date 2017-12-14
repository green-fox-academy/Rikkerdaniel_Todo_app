using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class Control
    {
        public  void Controller()
        {
            Console.WriteLine("Command line arguments :\n " +
                "-l   Lists all the tasks \n -a   Adds a new task \n" +
                " -r   Removes an task \n -c   Completes an task");
            string argument = Console.ReadLine();

            if (argument =="-l")
            {

            }
            else if (argument == "-a")
            {

            }
            else if (argument == "-r")
            {

            }
            else if (argument == "-c")
            {

            }
            else
            {
                Console.WriteLine("\n \n INVALID ARGUMENT YOU STUPID BASTARD!! \n \n");
                Controller();
            }


        }
    }
}
