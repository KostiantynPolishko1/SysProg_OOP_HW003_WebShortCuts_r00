using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SysProg_OOP_HW003_WebShortCuts_r00.Models;

namespace SysProg_OOP_HW003_WebShortCuts_r00.Controllers
{
    public static class UserProcess
    {
        public static (Process?, string) OpenWebPage(in string href, ProcessStartInfo psi)
        {
            try
            {
                psi.ArgumentList[psi.ArgumentList.Count - 1] = $"--new-tab {href}";
                Process ps = Process.Start(psi);
                ps.Refresh();

                return (ps, string.Empty);
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }           
        }

        public static List<Process>? StartProcesses(in List<webshortcut> items, in ProcessStartInfo psi, ref List<string> listMsg)
        {
            List<Process> list_ps = new List<Process>(items.Count);

            foreach (webshortcut item in items)
            {
                (Process? ps, string msg) = OpenWebPage(item.href, psi);

                if (ps != null) { list_ps.Add(ps); }
                else { listMsg.Add(msg); }        
            }

            return list_ps;
        }
    }
}
