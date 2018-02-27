 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using FoJaJo.Model;
using FoJaJo.DAL;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using WebService.Model;
using System.Data.Entity.Migrations;

namespace WebService
{

    [WebService(Namespace = "http://fojajo.ics.lu.se")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class FoJaJoWebService : System.Web.Services.WebService
    {

        SqlConnection connection = new SqlConnection("data source=DESKTOP-34D95N6;initial catalog=LuffarSchackDB;integrated security=True;");
        SqlConnection navConnection = new SqlConnection("data source=laptop-7hibdffa;initial catalog=Demo Database NAV (5-0); user id=sa; password=12345;");


        //////////////////
        ///LUFFARSCHACK///
        //////////////////

        [WebMethod]
        public string FindFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        [WebMethod]
        public Player GetPlayer(string username)
        {
            using (EntityContext ec = new EntityContext())
            {
                Player player = ec.Players.Find(username);
                return player;
            }
        }

        [WebMethod]
        public List<Player> GetAllPlayers()
        {
            using (EntityContext ec = new EntityContext())
            {
                List<Player> list = ec.Players.ToList();
                return list;
            }
        }

        [WebMethod]
        public List<Game> GetAllGames()
        {
            using (EntityContext ec = new EntityContext())
            {
                List<Game> list = ec.Games.ToList();
                return list;
            }
        }

        //////////////////
        //////CRONUS//////
        //////////////////

        [WebMethod]
        public Company SelectCompany(string companyName)
        {
            using (CronusContext cc = new CronusContext())
            {
                Company company = cc.Company.Find(companyName);
                return company;
            }
        }

        [WebMethod]
        public List<Company> SelectAllCompany()
        {
            using (CronusContext cc = new CronusContext())
            {
                List<Company> list = cc.Company.ToList();
                return list;
            }
        }

        [WebMethod]
        public void AddCompany(string companyName, string description)
        {
            using (CronusContext cc = new CronusContext())
            {
                Company company = new Company(companyName, description);
                cc.Company.Add(company);
                cc.SaveChanges();
            }
        }

        [WebMethod]
        public void RemoveCompany(string companyName)
        {
            using (CronusContext cc = new CronusContext())
            {
                Company company = SelectCompany(companyName);
                cc.Company.Attach(company);
                cc.Company.Remove(company);
                cc.SaveChanges();
            }
        }

        [WebMethod]
        public void UpdateCompany(string oldCompanyName, string description)
        {
            using (CronusContext cc = new CronusContext())
            {
                Company company = cc.Company.Find(oldCompanyName);
                company.Description = description;
                cc.SaveChanges();
            }
        }

        ///////////////////
        //CRONUS EMPLOYEE//
        ///////////////////

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee> GetAllEmployee()
        {
            using (CronusContext cc = new CronusContext())
            {
                List<CRONUS_Sverige_AB_Employee> list = cc.CRONUS_Sverige_AB_Employee.ToList();
                return list;
            }
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Absence> GetAllEmployeeAbsence()
        {
            using (CronusContext cc = new CronusContext())
            {
                List<CRONUS_Sverige_AB_Employee_Absence> list = cc.CRONUS_Sverige_AB_Employee_Absence.ToList();
                return list;
            }
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Portal_Setup> GetAllEmployeePortalSetup()
        {
            using (CronusContext cc = new CronusContext())
            {
                List<CRONUS_Sverige_AB_Employee_Portal_Setup> list = cc.CRONUS_Sverige_AB_Employee_Portal_Setup.ToList();
                return list;
            }
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Qualification> GetAllEmployeeQualification()
        {
            using (CronusContext cc = new CronusContext())
            {
                List<CRONUS_Sverige_AB_Employee_Qualification> list = cc.CRONUS_Sverige_AB_Employee_Qualification.ToList();
                return list;
            }
        }

        #region CRONUS
        #region MetaData
        [WebMethod]
        public List<MetaDataColumn> GetMetaColumns1()
        {
            List<MetaDataColumn> columns = new List<MetaDataColumn>();
            navConnection.Open();
            using (SqlCommand command = new SqlCommand("select top 20 [TABLE_CATALOG], [TABLE_NAME], [DATA_TYPE] from INFORMATION_SCHEMA.COLUMNS", navConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MetaDataColumn tmp = new MetaDataColumn
                        {
                            Table_Catalog = reader.GetValue(0) as string,
                            Table_Name = reader.GetValue(1) as string,
                            Data_Type = reader.GetValue(2) as string
                        };
                        columns.Add(tmp);
                    }
                }
            }
            navConnection.Close();
            return columns;
        }
        [WebMethod]
        public List<MetaDataColumn2> GetMetaColumns2()
        {
            List<MetaDataColumn2> columns = new List<MetaDataColumn2>();
            navConnection.Open();
            using (SqlCommand command = new SqlCommand("select top 20 name, user_type_id, object_id from sys.columns ", navConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MetaDataColumn2 tmp = new MetaDataColumn2
                        {
                            Name = reader.GetValue(0) as string,
                            User_type_Id = reader.GetInt32(1),
                            Object_Id = reader.GetInt32(2)
                        };
                        columns.Add(tmp);
                    }
                }
            }
            navConnection.Close();
            return columns;
        }

        [WebMethod]
        public List<MetaDataIndex> GetMetaIndexes()
        {
            List<MetaDataIndex> indexes = new List<MetaDataIndex>();
            navConnection.Open();
            using (SqlCommand command = new SqlCommand("select top 20 object_id, name, type_desc from sys.indexes", navConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MetaDataIndex tmp = new MetaDataIndex
                        {
                            Object_Id = reader.GetInt32(0),
                            Name = reader.GetValue(1) as string,
                            Type_Desc = reader.GetValue(2) as string
                        };
                        indexes.Add(tmp);
                    }
                }
            }
            navConnection.Close();
            return indexes;
        }

        [WebMethod]
        public List<MetaDataTableConstraint> GetMetaConstraints()
        {

            List<MetaDataTableConstraint> constraints = new List<MetaDataTableConstraint>();
            navConnection.Open();
            using (SqlCommand command = new SqlCommand("select top 20 [CONSTRAINT_NAME], [TABLE_NAME], [CONSTRAINT_TYPE] from INFORMATION_SCHEMA.TABLE_CONSTRAINTS", navConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MetaDataTableConstraint tmp = new MetaDataTableConstraint
                        {
                            Constraint_Name = reader.GetValue(0) as string,
                            Table_Name = reader.GetValue(1) as string,
                            Constraint_Type = reader.GetValue(2) as string
                        };
                        constraints.Add(tmp);
                    }
                }
            }
            navConnection.Close();
            return constraints;
        }

        [WebMethod]
        public List<MetaDataKey> GetMetaKeys()
        {

            List<MetaDataKey> keys = new List<MetaDataKey>();
            navConnection.Open();
            using (SqlCommand command = new SqlCommand("select top 20 [name], [object_id], [type] from sys.key_constraints", navConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MetaDataKey tmp = new MetaDataKey
                        {
                            Name = reader.GetValue(0) as string,
                            Object_Id = reader.GetInt32(1),
                            Type = reader.GetValue(2) as string
                        };
                        keys.Add(tmp);
                    }
                }
            }
            navConnection.Close();
            return keys;
        }
        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Relative> GetAllEmployeeRelative()
        {
            using (CronusContext cc = new CronusContext())
            {
                List<CRONUS_Sverige_AB_Employee_Relative> list = cc.CRONUS_Sverige_AB_Employee_Relative.ToList();
                return list;
            }
        }

        [WebMethod]
        public List<MetaDataTable> GetMetaTables()
        {
            List<MetaDataTable> tables = new List<MetaDataTable>();
            navConnection.Open();
            using (SqlCommand command = new SqlCommand("select top 20 [TABLE_NAME], [TABLE_TYPE] from INFORMATION_SCHEMA.TABLES", navConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MetaDataTable tmp = new MetaDataTable
                        {
                            Table_Name = reader.GetValue(0) as string,
                            Table_Type = reader.GetValue(1) as string
                        };
                        tables.Add(tmp);
                    }
                }
            }
            navConnection.Close();
            return tables;
        }
        public List<CRONUS_Sverige_AB_Employee_Statistics_Group> GetAllEmployeeStatisticsGroup()
        {
            using (CronusContext cc = new CronusContext())
            {
                List<CRONUS_Sverige_AB_Employee_Statistics_Group> list = cc.CRONUS_Sverige_AB_Employee_Statistics_Group.ToList();
                return list;
            }
        }

        [WebMethod]
        public List<MetaDataTable2> GetMetaTables2()
        {
            List<MetaDataTable2> tables = new List<MetaDataTable2>();
            navConnection.Open();
            using (SqlCommand command = new SqlCommand("select top 20 [name], [object_id] from sys.tables", navConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MetaDataTable2 tmp = new MetaDataTable2
                        {
                            Name = reader.GetValue(0) as string,
                            Object_Id = reader.GetInt32(1)
                        };
                        tables.Add(tmp);
                    }
                }
            }
            navConnection.Close();
            return tables;
        }
        #endregion

        [WebMethod]
        public void InsertCompany(string name)
        {
            navConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into Company values(default,'"+name+"')", navConnection);
            cmd.ExecuteNonQuery();
            navConnection.Close();
        }

        [WebMethod]
        public List<EmployeeRelative> GetEmployeeRelative()
        {
            List<EmployeeRelative> relatives = new List<EmployeeRelative>();
            navConnection.Open();
            using (SqlCommand command = new SqlCommand("select employee.[First Name], employee.[Last Name], employee.[Job Title], relative.[First Name], relative.[Relative Code] from[CRONUS Sverige AB$Employee] employee right join[CRONUS Sverige AB$Employee Relative] relative on employee.No_ = relative.[Employee No_]", navConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EmployeeRelative tmp = new EmployeeRelative
                        {
                            EmpFirstName = reader.GetValue(0) as string,
                            EmpLastName = reader.GetValue(1) as string,
                            EmpJobTitle = reader.GetValue(2) as string,
                            RelativeFirstName = reader.GetValue(3) as string,
                            RelativeCode = reader.GetValue(4) as string
                        };
                        relatives.Add(tmp);
                    }
                }
            }
            navConnection.Close();
            return relatives;
        }
        #endregion

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Relative> GetEmployeeRelatives(string employeeNr)
        {
            using (CronusContext cc = new CronusContext())
            {
                List<CRONUS_Sverige_AB_Employee_Relative> list = cc.CRONUS_Sverige_AB_Employee_Relative.Where(e => e.Employee_No_ == employeeNr).ToList();
                return list;
            }
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Absence> GetEmployeeAbsence()
        {
            using (CronusContext cc = new CronusContext())
            {
                List<CRONUS_Sverige_AB_Employee_Absence> list = cc.CRONUS_Sverige_AB_Employee_Absence.Where(e => e.From_Date.Year == 2004).ToList();
                return list;
            }
        }



    }
}
