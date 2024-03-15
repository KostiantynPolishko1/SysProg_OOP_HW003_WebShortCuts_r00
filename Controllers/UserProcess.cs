using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SysProg_OOP_HW003_WebShortCuts_r00.Models;
using SysProg_OOP_HW003_WebShortCuts_r00.Exceptions;
using Microsoft.EntityFrameworkCore.Query;

namespace SysProg_OOP_HW003_WebShortCuts_r00.Controllers
{
    public static class UserProcess
    {
        public static (Process?, string) OpenWebPage(in string href, ProcessStartInfo psi)
        {
            try
            {
                psi.ArgumentList[psi.ArgumentList.Count - 1] = $"--new-tab {href}";
                Process? ps = Process.Start(psi);

                if (ps == null)
                {
                    throw new ProcessNotStartException(href);
                }

                ps.Refresh();

                return (ps, string.Empty);
            }
            catch (SystemException ex)
            {
                return (null, ex.Message);
            }
            catch (ProcessNotStartException ex)
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

/*        public static string CloseWebPage(in Process ps)
        {
            try
            {
                for(int i = 0; i != 3; i++)
                {
                    if (!ps.HasExited)
                    {
                        ps.Refresh();
                        Thread.Sleep(2000);
                    }
                    else { break; }
                }
                ps.CloseMainWindow();
                ps.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                //ps.Kill();
                ps.Dispose();
            }
            catch (SystemException ex)
            {
                return ex.Message;
            }

            return string.Empty;
        }*/

/*        public static string CloseWebPage(in webshortcut web)
        {
            try
            {
                //ProcessStartInfo psi = new ProcessStartInfo() { FileName = "cmd.exe", RedirectStandardInput = true, UseShellExecute = false, CreateNoWindow = true };
                
                Process pc = Process.Start(new ProcessStartInfo() 
                { 
                    FileName = "cmd.exe", 
                    RedirectStandardInput = true, 
                    UseShellExecute = false, 
                    CreateNoWindow = true 
                });

                if (!pc.HasExited)
                {
                    pc.StandardInput.WriteLine($"taskkill /F /FI \"WINDOWTITLE eq {web.href} - Google Chrome\"");
                    pc.StandardInput.Flush();
                    pc.StandardInput.Close();
                    pc.WaitForExit();
                }
            }
            catch (SystemException ex)
            {
                return ex.Message;
            }

            return string.Empty;
        }*/
    
    
    }
}
