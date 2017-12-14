using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class AddTask
    {
        public static string path = @"C:\Users\rikda\Desktop\asbest\greenfox\TodoApp\Rikkerdaniel_handle_Todo_app\TodoApp\TodoApp\Todo.txt";
        public void AddNewTask(string task)
        {
            var sw = new StreamWriter(path, true);
            sw.WriteLine("[]"+task);

            sw.Close();
        }
    }
}
