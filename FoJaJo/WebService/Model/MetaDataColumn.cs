using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class MetaDataColumn
    {
        public string Table_Catalog { get; set; }
        public string Table_Name { get; set; }
        public string Data_Type { get; set; }

        public MetaDataColumn() { }
        public MetaDataColumn(string catalog, string name, string type)
        {
            Table_Catalog = catalog;
            Table_Name = name;
            Data_Type = type;
        }
    }
    
}