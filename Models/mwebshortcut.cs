using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysProg_OOP_HW003_WebShortCuts_r00.Models
{
    public partial class webshortcut
    {
        public webshortcut() : this(0, string.Empty, string.Empty) { }

        public webshortcut(string href, in string name) : this(0, href, name) { }

        public webshortcut(int id, in string href, string name) 
        { 
            this.id = id;
            this.href = href;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{id} | name: {name} | href: {href}";
        }
    }
}
