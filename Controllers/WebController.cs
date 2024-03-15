using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SysProg_OOP_HW003_WebShortCuts_r00.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysProg_OOP_HW003_WebShortCuts_r00.Controllers
{
    public sealed class WebController : db_aa534b_polxswp31Context
    {
        public WebController() : base() { }

        public bool IsConnection() => Database.CanConnect();
    }
}
