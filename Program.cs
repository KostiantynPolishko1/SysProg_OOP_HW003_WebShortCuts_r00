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
            
            if(db.IsConnection()) { WebController.WriteInfo(db.webshortcuts.ToList()); }
            else
            {
                Console.WriteLine($"{db.Database.ProviderName} no connection");
                Environment.Exit(0);
            }

            PsiSet psiSet = new PsiSet() { };

            List<string> listMsg = new List<string>();
            List<Process>? processes = UserProcess.StartProcesses(db.webshortcuts.ToList(), psiSet.psi, ref listMsg);

            WebController.WriteInfo(listMsg);
        }
    }
}