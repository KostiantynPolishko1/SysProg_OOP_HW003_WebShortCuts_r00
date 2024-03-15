using SysProg_OOP_HW003_WebShortCuts_r00.Controllers;
using SysProg_OOP_HW003_WebShortCuts_r00.Models;
using System.Diagnostics;

namespace SysProg_OOP_HW003_WebShortCuts_r00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            WebController db = new WebController() { };
            Console.WriteLine(db.IsConnection());

            PsiSet psiSet = new PsiSet() { };

            foreach(webshortcut item in db.webshortcuts.ToList())
            {
                Console.WriteLine(item);
            }

            Process process = Process.Start(psiSet.psi);

            process.Refresh();
        }
    }
}