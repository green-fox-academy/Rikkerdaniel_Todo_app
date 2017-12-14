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
        public static string path = @"C:\Users\rikda\Desktop\asbest\greenfox\TodoApp\Rikkerdaniel_handle_Todo_app\TodoApp\TodoApp\Todo.txt";

        public void PrinterAll()
        {
            var sr = new StreamReader(path);
            string line1 = string.Empty;
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
            string[] lines = File.ReadAllLines(path);
            var sw = new StreamWriter(path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (i == check)
                {
                    string rep = lines[check];
                    rep.Replace("[]", "[X]");
                    sw.WriteLine(rep);
                }
                else
                {
                    sw.WriteLine(lines[i]);
                }
            }
            sw.Close();
        }
    }
}

