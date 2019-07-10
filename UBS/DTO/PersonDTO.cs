using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBS.DTO
{
    public class PersonDTO
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string  email { get; set; }
        public string gender { set; get; }
        public string address { set; get; }
        public string State { get; set; }
        public string Company { get; set; }
        public string Hash { get; set; }

    }
}
