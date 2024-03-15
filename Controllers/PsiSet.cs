using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SysProg_OOP_HW003_WebShortCuts_r00.Controllers
{
    public class PsiSet
    {
        public ProcessStartInfo psi { get; private set; }

        public PsiSet() : this("chrome.exe", true, "C:\\Program Files\\Google\\Chrome\\Application", "--incognito") { }
        public PsiSet(in string fileName) : this(fileName, false, null) { }
        public PsiSet(in string fileName, bool useShellExecute, in string? workingDirectory, params string[] args) 
        { 
            psi = new ProcessStartInfo() { FileName = fileName };

            psi.UseShellExecute = useShellExecute;
            if (useShellExecute) { psi.WorkingDirectory = workingDirectory; }              

            foreach (string arg in args) { psi.ArgumentList.Add(arg); }
            psi.ArgumentList.Add("");
        }
    }
}
