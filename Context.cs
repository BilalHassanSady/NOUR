using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nour.model;


namespace Nour
{
    internal static class Context
    {
        public static object context { get; set; }
        public static Account Account { get; set; }
    }
}
