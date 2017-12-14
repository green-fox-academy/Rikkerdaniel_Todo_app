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
        public void PrinterAll()
        {
            var sr = new StreamReader(@"C:\Users\rikda\Desktop\asbest\greenfox\Rikkerdaniel\week-03\day-01\ReverseLines\rev.txt");
            string line1 = "";
            int counter = 1;
            while ((line1 = sr.ReadLine()) != null)
            {
                Console.WriteLine(counter + "  " + line1);
                counter++;
            }
            sr.Close();

        }
        public void PrintCheck(int check)
        {
            var sr = new StreamReader(@"C:\Users\rikda\Desktop\asbest\greenfox\Rikkerdaniel\week-03\day-01\ReverseLines\rev.txt");
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
