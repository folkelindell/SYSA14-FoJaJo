using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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
            try
            {
                string str = client.FindFile(filePath);
                return str;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<Player> GetAllPlayers()
        {
            try
            {
                EntityContext ec = new EntityContext();
                List<Player> list = new List<Player>(client.GetAllPlayers());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
         
        }
        #endregion

        #region ERP

        #region Metadata
        public List<MetaDataColumn> GetMetaColumns()
        {
            try
            {
                List<MetaDataColumn> list = new List<MetaDataColumn>(client.GetMetaColumns1());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        
        public List<MetaDataColumn2> GetMetaColumns2()
        {
            try
            {
                List<MetaDataColumn2> list = new List<MetaDataColumn2>(client.GetMetaColumns2());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<MetaDataIndex> getMetaIndexes()
        {
            try
            {
                List<MetaDataIndex> list = new List<MetaDataIndex>(client.GetMetaIndexes());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
         }

        public List<MetaDataKey> getMetaKeys()
        {
            try
            {
                List<MetaDataKey> list = new List<MetaDataKey>(client.GetMetaKeys());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<MetaDataTable> getMetaTables()
        {
            try
            {
                List<MetaDataTable> list = new List<MetaDataTable>(client.GetMetaTables());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<MetaDataTable2> getMetaTables2()
        {
            try
            {
                List<MetaDataTable2> list = new List<MetaDataTable2>(client.GetMetaTables2());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<MetaDataTableConstraint> getMetaTablesConstraints()
        {
            try
            {
                List<MetaDataTableConstraint> list = new List<MetaDataTableConstraint>(client.GetMetaConstraints());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        #endregion

        public void AddCompany(string name, string desc)
        {
            try
            {
                client.AddCompany(name, desc);
            }
            catch (DbUpdateException)
            {
                Console.WriteLine("DBUPDAte");
            }
            catch (SqlException)
            {
                Console.WriteLine("SQLEXC");
            }
            catch(Exception e)
            {
                Console.WriteLine("GENERALEXC");
            }
            
        }

        public Company SelectCompany(string name)
        {
            try
            {
                Company c = client.SelectCompany(name);
                return c;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<Company> SelectAllCompany()
        {
            try
            {
                List<Company> list = new List<Company>(client.SelectAllCompany());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void RemoveCompany(string name)
        {
            try
            {
                client.RemoveCompany(name);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void UpdateCompany(string name, string desc)
        {
            try
            {
                client.UpdateCompany(name, desc);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public  List<CRONUS_Sverige_AB_Employee> GetAllEmployees()
        {
            try
            {
                List<CRONUS_Sverige_AB_Employee> list = new List<CRONUS_Sverige_AB_Employee>(client.GetAllEmployee());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<EmployeeRelative> GetEmployeeRelatives()
        {
            try
            {
                List<EmployeeRelative> list = new List<EmployeeRelative>(client.GetEmployeeRelative());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<CRONUS_Sverige_AB_Employee_Absence> GetEmployeeAbsence()
        {
            try
            {
                List<CRONUS_Sverige_AB_Employee_Absence> list = new List<CRONUS_Sverige_AB_Employee_Absence>(client.GetEmployeeAbsence());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<CRONUS_Sverige_AB_Employee_Absence> GetAllEmployeeAbsence()
        {
            try
            {
                List<CRONUS_Sverige_AB_Employee_Absence> list = new List<CRONUS_Sverige_AB_Employee_Absence>(client.GetAllEmployeeAbsence());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<MostSick> GetMostSick()
        {
            try
            {
                List<MostSick> list = new List<MostSick>(client.GetMostSick());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<CRONUS_Sverige_AB_Employee_Portal_Setup> GetAllPortalSetup()
        {
            try
            {
                List<CRONUS_Sverige_AB_Employee_Portal_Setup> list = new List<CRONUS_Sverige_AB_Employee_Portal_Setup>(client.GetAllEmployeePortalSetup());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<CRONUS_Sverige_AB_Employee_Qualification> GetAllQualification()
        {
            try
            {
                List<CRONUS_Sverige_AB_Employee_Qualification> list = new List<CRONUS_Sverige_AB_Employee_Qualification>(client.GetAllEmployeeQualification());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<CRONUS_Sverige_AB_Employee_Relative> getRelatives()
        {
            try
            {
                List<CRONUS_Sverige_AB_Employee_Relative> list = new List<CRONUS_Sverige_AB_Employee_Relative>(client.GetAllEmployeeRelative());
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<Company> GetCompany(string name)
        {
            try
            {
                List<Company> list = new List<Company>();
                list.Add(client.SelectCompany(name));
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        #endregion


    }
}
