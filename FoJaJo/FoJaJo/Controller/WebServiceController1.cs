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

        public void AddCompany(string name, string desc)
        {
            client.AddCompany(name, desc);
        }

        public Company SelectCompany(string name)
        {
            Company c = client.SelectCompany(name);
            return c;
        }

        public List<Company> SelectAllCompany()
        {
            List<Company> list = new List<Company>(client.SelectAllCompany());
            return list;
        }

        public void RemoveCompany(string name)
        {
            client.RemoveCompany(name);
        }

        public void UpdateCompany(string name, string desc)
        {
            client.UpdateCompany(name, desc);
        }
        public  List<CRONUS_Sverige_AB_Employee> GetAllEmployees()
        {
            List<CRONUS_Sverige_AB_Employee> list = new List<CRONUS_Sverige_AB_Employee>(client.GetAllEmployee());
            return list;
        }

        public List<EmployeeRelative> GetEmployeeRelatives()
        {
            List<EmployeeRelative> list = new List<EmployeeRelative>(client.GetEmployeeRelative());
            return list;
        }

        public List<CRONUS_Sverige_AB_Employee_Absence> GetEmployeeAbsence()
        {
            List<CRONUS_Sverige_AB_Employee_Absence> list = new List<CRONUS_Sverige_AB_Employee_Absence>(client.GetEmployeeAbsence());
            return list;
        }

        public List<CRONUS_Sverige_AB_Employee_Absence> GetAllEmployeeAbsence()
        {
            List<CRONUS_Sverige_AB_Employee_Absence> list = new List<CRONUS_Sverige_AB_Employee_Absence>(client.GetAllEmployeeAbsence());
            return list;
        }

        public List<MostSick> GetMostSick()
        {
            List<MostSick> list = new List<MostSick>(client.GetMostSick());
            return list;
        }

        public List<CRONUS_Sverige_AB_Employee_Portal_Setup> GetAllPortalSetup()
        {
            List<CRONUS_Sverige_AB_Employee_Portal_Setup> list = new List<CRONUS_Sverige_AB_Employee_Portal_Setup>(client.GetAllEmployeePortalSetup());
            return list;
        }

        public List<CRONUS_Sverige_AB_Employee_Qualification> GetAllQualification()
        {
            List<CRONUS_Sverige_AB_Employee_Qualification> list = new List<CRONUS_Sverige_AB_Employee_Qualification>(client.GetAllEmployeeQualification());
            return list;
        }

        public List<CRONUS_Sverige_AB_Employee_Relative> getRelatives()
        {
            List<CRONUS_Sverige_AB_Employee_Relative> list = new List<CRONUS_Sverige_AB_Employee_Relative>(client.GetAllEmployeeRelative());
            return list;
        }

        public List<Company> GetCompany(string name)
        {

            List<Company> list = new List<Company>();
            list.Add(client.SelectCompany(name));
            return list;
        }


        #endregion


    }
}
