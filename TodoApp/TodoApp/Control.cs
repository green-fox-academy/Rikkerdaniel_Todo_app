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
        public void Controller(string[] argument)
        {
            
            try
            {
                if (argument[0] == "-l")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    var pr = new Print();
                    pr.PrinterAll();
                }
                else if (argument[0] == "-a")
                {
                    var wrtFile = new AddTask();

                    string newTask = argument[1];
                    if (newTask.Length < 1)
                    {
                        Console.WriteLine("not real Task");
                    }
                    else
                    {
                        wrtFile.AddNewTask(newTask);
                    }
                }
                else if (argument[0] == "-r")
                {
                    var rm = new Remove();
                    int removeThis = int.Parse(argument[1]);
                    rm.RemoveTask(removeThis);
                }
                else if (argument[0] == "-c")
                {
                    var pr = new Print();
                    int CheckThis = int.Parse(argument[1]);
                    if (CheckThis == 0)
                    {
                        pr.PrintCheck(CheckThis);
                    }
                    else
                    {
                        pr.PrintCheck(CheckThis - 1);
                    }
                }
                else
                {
                    Console.WriteLine("\n \n INVALID ARGUMENT YOU STUPID BASTARD!! \n \n");
                    Console.WriteLine("=============================\n\n" +
                    "\n Command line arguments :\n " +
                    "-l   Lists all the tasks \n -a   Adds a new task \n" +
                    " -r   Removes an task \n -c   Completes an task");
                }
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine("asdasd");
                Console.WriteLine(e);
            }


        }
    }
}
