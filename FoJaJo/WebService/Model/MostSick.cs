using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class MostSick
    {
        public string Name { get; set; }

        public MostSick() { }
        public MostSick(string name)
        {
            Name = name;
        }
    }
}