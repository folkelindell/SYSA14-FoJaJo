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
using System.Data.Entity.Core;
using System.Web.Services.Protocols;

namespace WebService
{

    [WebService(Namespace = "http://fojajo.ics.lu.se")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class FoJaJoWebService : System.Web.Services.WebService
    {
        SqlConnection navConnection = new SqlConnection("data source=DESKTOP-34D95N6;initial catalog=Demo Database NAV (5-0); user id=sa; password=12345;");

        #region LUFFARSCHACK
        [WebMethod]
        public string FindFile(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public Player GetPlayer(string username)
        {
            try
            {
                using (EntityContext ec = new EntityContext())
                {
                    Player player = ec.Players.Find(username);
                    return player;
                }
            }
            catch(Exception)
            {
                throw;
            }
            
        }

        [WebMethod]
        public List<Player> GetAllPlayers()
        {
            try
            {
                using (EntityContext ec = new EntityContext())
                {
                    List<Player> list = ec.Players.ToList();
                    return list;
                }
            }
            catch
            {
                throw;
            }
            
        }

        [WebMethod]
        public List<Game> GetAllGames()
        {
            try
            {
                using (EntityContext ec = new EntityContext())
                {
                    List<Game> list = ec.Games.ToList();
                    return list;
                }
            }catch(Exception)
            {
                throw;
            }
            
        }

        #endregion

        #region CRONUS

        #region CRONUS COMPANY
        [WebMethod]
        public Company SelectCompany(string companyName)
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    Company company = cc.Company.Find(companyName);
                    return company;
                }
            }
            catch(Exception)
            {
                throw;
            }
            
        }

        [WebMethod]
        public List<Company> SelectAllCompany()
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    List<Company> list = cc.Company.ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [WebMethod]
        public void AddCompany(string companyName, string description)
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    if (companyName != "")
                    {
                        Company company = new Company(companyName, description);
                        cc.Company.Add(company);
                        cc.SaveChanges();
                    }
                    else
                    {
                        companyName = null;
                        Company company = new Company(companyName, description);
                        cc.Company.Add(company);
                        cc.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public void RemoveCompany(string companyName)
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    Company company = SelectCompany(companyName);
                    cc.Company.Attach(company);
                    cc.Company.Remove(company);
                    cc.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [WebMethod]
        public void UpdateCompany(string oldCompanyName, string description)
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    Company company = cc.Company.Find(oldCompanyName);
                    company.Description = description;
                    cc.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        #endregion

        #region CRONUS EMPLOYEE

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee> GetAllEmployee()
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    List<CRONUS_Sverige_AB_Employee> list = cc.CRONUS_Sverige_AB_Employee.ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Absence> GetAllEmployeeAbsence()
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    List<CRONUS_Sverige_AB_Employee_Absence> list = cc.CRONUS_Sverige_AB_Employee_Absence.ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Portal_Setup> GetAllEmployeePortalSetup()
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    List<CRONUS_Sverige_AB_Employee_Portal_Setup> list = cc.CRONUS_Sverige_AB_Employee_Portal_Setup.ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Qualification> GetAllEmployeeQualification()
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    List<CRONUS_Sverige_AB_Employee_Qualification> list = cc.CRONUS_Sverige_AB_Employee_Qualification.ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Relative> GetEmployeeRelatives(string employeeNr)
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    List<CRONUS_Sverige_AB_Employee_Relative> list = cc.CRONUS_Sverige_AB_Employee_Relative.Where(e => e.Employee_No_ == employeeNr).ToList();
                    return list;
                }
            }
            catch
            {
                throw;
            }
            
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Absence> GetEmployeeAbsence2004()
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    List<CRONUS_Sverige_AB_Employee_Absence> list = cc.CRONUS_Sverige_AB_Employee_Absence.Where(e => e.From_Date.Year == 2004).ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Relative> GetAllEmployeeRelative()
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    List<CRONUS_Sverige_AB_Employee_Relative> list = cc.CRONUS_Sverige_AB_Employee_Relative.ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Statistics_Group> GetAllEmployeeStatisticsGroup()
        {
            try
            {
                using (CronusContext cc = new CronusContext())
                {
                    List<CRONUS_Sverige_AB_Employee_Statistics_Group> list = cc.CRONUS_Sverige_AB_Employee_Statistics_Group.ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [WebMethod]
        public List<EmployeeRelative> GetEmployeeRelative()
        {
            try
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                navConnection.Close();
            }

        }

        [WebMethod]
        public List<MostSick> GetMostSick()
        {
            try
            {
                List<MostSick> list = new List<MostSick>();
                navConnection.Open();
                using (SqlCommand command = new SqlCommand("select top 5 [First Name] from [CRONUS Sverige AB$Employee] where No_ in(select[Employee No_] from[CRONUS Sverige AB$Employee Absence] where[Cause of Absence Code] = 'SJUK' group by[Employee No_])", navConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MostSick tmp = new MostSick
                            {
                                Name = reader.GetValue(0) as string,
                            };
                            list.Add(tmp);
                        }
                    }
                }
                navConnection.Close();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                navConnection.Close();
            }
            
        }
        #endregion

        #region CRONUS METADATA
        [WebMethod]
        public List<MetaDataColumn> GetMetaColumns1()
        {
            try
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                navConnection.Close();
            }

        }
        [WebMethod]
        public List<MetaDataColumn2> GetMetaColumns2()
        {
            try
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                navConnection.Close();
            }

        }

        [WebMethod]
        public List<MetaDataIndex> GetMetaIndexes()
        {
            try
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                navConnection.Close();
            }
  
        }

        [WebMethod]
        public List<MetaDataTableConstraint> GetMetaConstraints()
        {
            try
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
            catch (Exception)
            { 
                throw;
            }
            finally
            {
                navConnection.Close();
            }
        }

        [WebMethod]
        public List<MetaDataKey> GetMetaKeys()
        {
            try
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                navConnection.Close();
            }
        }
        

        [WebMethod]
        public List<MetaDataTable> GetMetaTables()
        {
            try
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                navConnection.Close();
            }
        }
        

        [WebMethod]
        public List<MetaDataTable2> GetMetaTables2()
        {
            try
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                navConnection.Close();
            }

        }
        #endregion

        #endregion

    }
}
