using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class MetaDataColumn2
    {
        public string Name { get; set; }
        public int User_type_Id { get; set; }
        public int Object_Id { get; set; }

        public MetaDataColumn2() { }
        public MetaDataColumn2(string name, int type_Id, int object_Id)
        {
            Name = name;
            User_type_Id = type_Id;
            Object_Id = object_Id;
        }
    }
}