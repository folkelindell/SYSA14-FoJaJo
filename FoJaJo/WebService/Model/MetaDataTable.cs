using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class MetaDataTable
    {
        public string Table_Name { get; set; }
        public string Table_Type { get; set; }

        //select top 20 [TABLE_NAME], [TABLE_TYPE] from INFORMATION_SCHEMA.TABLES
        public MetaDataTable() { }
        public MetaDataTable(string name, string type)
        {
            Table_Name = name;
            Table_Type = type;
        }
    }
}