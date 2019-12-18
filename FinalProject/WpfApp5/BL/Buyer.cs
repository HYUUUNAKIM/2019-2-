using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.BL
{
    class Buyer
    {
        public Buyer(string id, string passwd)
        {
            Id = id;
            Passwd = passwd;
        }

        public string Id { get; set; }
        public string Passwd { get; set; }

    }
}
