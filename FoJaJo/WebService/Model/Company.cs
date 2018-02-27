using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class Company
    {
        public string Name{ get; set; }
        public string TimeStamp{ get; set; }

        public Company() { }
        public Company(string name) {
            Name = name;
            TimeStamp = "default";
        }

    }
}