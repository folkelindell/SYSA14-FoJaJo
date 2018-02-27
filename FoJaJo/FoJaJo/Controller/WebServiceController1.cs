using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.DAL;
using FoJaJo.FoJaJoWebService;

namespace FoJaJo.Controller
{
    class WebServiceController1
    {

        FoJaJoWebServiceSoapClient client = new FoJaJoWebServiceSoapClient();

        #region uppgift2
        public string OpenFile(string filePath)
        {
            string str = client.FindFile(filePath);
            return str;
        }

        public List<Player> GetAllPlayers()
        {
            EntityContext ec = new EntityContext();
            List<Player> list = new List<Player>(client.GetAllPlayers());
            return list;
        }
        #endregion

        #region ERP
        #region Metadata
        public List<MetaDataColumn> GetMetaColumns()
        {
            List<MetaDataColumn> list = new List<MetaDataColumn>(client.GetMetaColumns1());
            return list;
        }
        
        public List<MetaDataColumn2> GetMetaColumns2()
        {
            List<MetaDataColumn2> list = new List<MetaDataColumn2>(client.GetMetaColumns2());
            return list;
        }

        public List<MetaDataIndex> getMetaIndexes()
        {
            List<MetaDataIndex> list = new List<MetaDataIndex>(client.GetMetaIndexes());
            return list;
         }

        public List<MetaDataKey> getMetaKeys()
        {
            List<MetaDataKey> list = new List<MetaDataKey>(client.GetMetaKeys());
            return list;
        }

        public List<MetaDataTable> getMetaTables()
        {
            List<MetaDataTable> list = new List<MetaDataTable>(client.GetMetaTables());
            return list;
        }

        public List<MetaDataTable2> getMetaTables2()
        {
            List<MetaDataTable2> list = new List<MetaDataTable2>(client.GetMetaTables2());
            return list;
        }

        public List<MetaDataTableConstraint> getMetaTablesConstraints()
        {
            List<MetaDataTableConstraint> list = new List<MetaDataTableConstraint>(client.GetMetaConstraints());
            return list;
        }
        #endregion
        public void InsertCompany(string name)
        {
            client.InsertCompany(name);
        }
        public List<EmployeeRelative> getEmployeeRelatives()
        {
            List<EmployeeRelative> list = new List<EmployeeRelative>(client.GetEmployeeRelative());
            return list;
        }

        #endregion


    }
}
