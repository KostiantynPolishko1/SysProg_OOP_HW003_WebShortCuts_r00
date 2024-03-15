using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysProg_OOP_HW003_WebShortCuts_r00.Models
{
    public partial class webtrack
    {
        public webtrack() : 
            this (0, DateTime.UtcNow.ToLocalTime(), DateTime.UtcNow.ToLocalTime().TimeOfDay, "empty", "unknown", "unknown") { }

        public webtrack(in string url, in string name, in string owner) : 
            this (0, DateTime.UtcNow.ToLocalTime(), DateTime.UtcNow.ToLocalTime().TimeOfDay, url, name, owner) { }

        public webtrack(int id, DateTime date, TimeSpan time, in string url, in string name, in string owner)
        {
            this.id = id;
            this.date = date;
            this.time = time;
            this.url = url;
            this.name = name;
            this.owner = owner;
        }
    }
}
