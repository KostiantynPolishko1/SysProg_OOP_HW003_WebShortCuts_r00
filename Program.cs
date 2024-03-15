using SysProg_OOP_HW003_WebShortCuts_r00.Models;

namespace SysProg_OOP_HW003_WebShortCuts_r00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            WebDbContext db = new WebDbContext() { };

            Console.WriteLine(db.IsConnection());
            foreach(webshortcut item in db.webshortcuts.ToList())
            {
                Console.WriteLine(item);
            }
        }
    }
}