using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WienCore2019.Pages.modul09
{
    public class Class
    {
    }
    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public int id { get; set; }
        public int kundenID { get; set; }
        public DateTime datum { get; set; }
        public int? summe { get; set; }
        public object[] positionen { get; set; }
    }

}
