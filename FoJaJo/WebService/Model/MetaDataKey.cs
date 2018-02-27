using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class MetaDataKey
    {
        public string Name { get; set; }
        public int Object_Id { get; set; }
        public string Type { get; set; }
       
        public MetaDataKey() { }

        public MetaDataKey(string name, int object_Id, string type)
        {
            Name = name;
            Object_Id = object_Id;
            Type = type;
        }
    }
}