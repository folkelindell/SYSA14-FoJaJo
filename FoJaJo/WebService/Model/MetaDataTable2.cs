using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class MetaDataTable2
    {
        public string Name { get; set; }
        public int Object_Id { get; set; }

        //select top 20 [name], [object_id]  from sys.tables
        public MetaDataTable2() { }
        public MetaDataTable2(string s)
        {

        }
    }
}