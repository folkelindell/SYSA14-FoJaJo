using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class MetaDataTableConstraint
    {
        public string Constraint_Name { get; set; }
        public string Table_Name { get; set; }
        public string Constraint_Type { get; set; }

        public MetaDataTableConstraint() { }

        public MetaDataTableConstraint(string constraint_Name, string table_Name, string constraint_Type )
        {
            Constraint_Name = constraint_Name;
            Table_Name = table_Name;
            Constraint_Type = constraint_Type;
        }
        
    }
}