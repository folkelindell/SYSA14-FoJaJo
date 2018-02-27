using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class MetaDataIndex
    {
        public int Object_Id { get; set; }
        public string Name { get; set; }
        public string Type_Desc { get; set; }
        
        public MetaDataIndex() { }
        public MetaDataIndex(int id, string name, string type)
        {
            Object_Id = id;
            Name = name;
            Type_Desc = type;
        }
    }
}