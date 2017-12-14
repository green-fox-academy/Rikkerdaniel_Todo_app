using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class Control
    {
        public void Controller()
        {
            Console.WriteLine("=============================\n\n" +
                "\n Command line arguments :\n " +
                "-l   Lists all the tasks \n -a   Adds a new task \n" +
                " -r   Removes an task \n -c   Completes an task");
            string argument = Console.ReadLine();

            if (argument == "-l")
            {
                var pr = new Print();

                pr.PrinterAll();


            }
            else if (argument == "-a")
            {
                Console.WriteLine("give me that new task ");
                string newTask = Console.ReadLine();
                // WriteTask();

            }
            else if (argument == "-r")
            {

            }
            else if (argument == "-c")
            {
                var pr = new Print();
                Console.WriteLine("wich argument do you want to check?");
                int CheckThis = int.Parse(Console.ReadLine());
                pr.PrintCheck(CheckThis);
            }
            else
            {
                Console.WriteLine("\n \n INVALID ARGUMENT YOU STUPID BASTARD!! \n \n");
            }
            Controller();

        }
    }
}
