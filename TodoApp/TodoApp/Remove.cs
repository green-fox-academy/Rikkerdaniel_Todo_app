using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class Remove
    {
        public static string path = @"C:\Users\rikda\Desktop\asbest\greenfox\TodoApp\Rikkerdaniel_handle_Todo_app\TodoApp\TodoApp\Todo.txt";
        public void RemoveTask(int task)
        {
            string[] lines = File.ReadAllLines(path);
            var sw = new StreamWriter(path);
            for (int i = 0; i < task - 1; i++)
            {
                sw.WriteLine(lines[i]);
            }
            for (int i = task; i < lines.Length; i++)
            {
                sw.WriteLine(lines[i]);
            }
            sw.Close();
        }
    }
}
