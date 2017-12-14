using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class Print
    {
        public static string path = @"C:\Users\rikda\Desktop\asbest\greenfox\TodoApp\Rikkerdaniel_handle_Todo_app\TodoApp\TodoApp\Todo.txt.txt";

        public void PrinterAll()
        {
            var sr = new StreamReader(path );
            string line1 = "";
            int counter = 1;
            if (sr.ReadLine() == null)
            {
                Console.WriteLine("\n YOUR LIST IS EMPTY !!  \n");
            }
            else
            {
                Console.WriteLine("\n \n");
                while ((line1 = sr.ReadLine()) != null)
                {
                    Console.WriteLine(counter + "  " + line1);
                    counter++;
                }
            }
            sr.Close();
        }

        public void PrintCheck(int check)
        {
            var sr = new StreamReader(path);
            string line1 = "";
            int nthCheck = 0;
            while ((line1 = sr.ReadLine()) != null)
            {

                if (nthCheck == check)
                {
                    Console.WriteLine("[X] " + line1);
                }
                else
                {
                    Console.WriteLine("[ ] " + line1);

                }
                nthCheck++;

            }
            sr.Close();
        }
    }
}
