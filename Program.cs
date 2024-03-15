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

            /*            if (db.IsConnection()) { WebController.WriteInfo(db.webshortcuts.ToList()); }
                        else
                        {
                            Console.WriteLine($"{db.Database.ProviderName} no connection");
                            Environment.Exit(0);
                        }*/

            /*            PsiSet psiSet = new PsiSet() { };

                        List<string> listMsg = new List<string>();
                        List<Process>? processes = UserProcess.StartProcesses(db.webshortcuts.ToList(), psiSet.psi, ref listMsg);

                        WebController.WriteInfo(listMsg);*/


            /*            DateTime date = DateTime.UtcNow.ToLocalTime();
                        TimeSpan time = new TimeSpan(0, date.Hour, date.Minute, date.Second, date.Millisecond);

                        webtrack web = new webtrack() { date = date, time = time, url = "url2", name = "name2", owner = "owner1" };
                        db.webtracks.Add(web);*/

            db.webtracks.Add(new webtrack("empty", "unknown", "unknown") { });
            db.SaveChanges();
        }
    }
}