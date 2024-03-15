using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SysProg_OOP_HW003_WebShortCuts_r00.Controllers
{
    public static class UserProcess
    {
        public static (bool, string) OpenUrl(in string href, ref PsiSet psiSet)
        {
            try
            {
                psiSet.psi.ArgumentList[psiSet.psi.ArgumentList.Count - 1] = $"-- new-tab {href}";
                Process.Start(psiSet.psi);

                return (false, string.Empty);
            }
            catch
            {
                return (true, "Erorr");
            }           
        }
    }
}
