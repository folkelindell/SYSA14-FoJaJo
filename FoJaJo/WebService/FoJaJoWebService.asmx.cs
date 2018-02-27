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
using System.Data.Entity.Migrations;

namespace WebService
{

    [WebService(Namespace = "http://fojajo.ics.lu.se")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class FoJaJoWebService : System.Web.Services.WebService
    {

        SqlConnection connection = new SqlConnection("data source=DESKTOP-34D95N6;initial catalog=LuffarSchackDB;integrated security=True;");
        SqlConnection erpConnection = new SqlConnection("data source=DESKTOP-34D95N6;initial catalog=Demo Database NAV (5-0); user id=sa; password=12345;");

        //QUERYS
        readonly string getInfoSchemCol = "select * from INFORMATION_SCHEMA.COLUMNS where table_name = 'CRONUS Sverige AB$Employee'";
        readonly string getSysCol = "select * from sys.columns where object_id = object_id('CRONUS Sverige AB$Employee')";
        readonly string getInfoSchemTable = "select * from INFORMATION_SCHEMA.TABLES";
        readonly string getSysTable = "select * from sys.tables";
        readonly string getKeys = "select * from sys.key_constraints";
        readonly string getAllTablCon = "select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS";
        readonly string getMinCol = "SELECT TABLE_SCHEMA, TABLE_NAME, number = COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS GROUP BY TABLE_SCHEMA, TABLE_NAME HAVING (COUNT(*) < 3)";
        readonly string getAllSick = "select [timestamp], [Entry No_], [From Date], [To Date], [Description] from [CRONUS Sverige AB$Employee Absence] where [From Date] <'2005-01-01 00:00:00:000'";
        readonly string getInfoPersRealtives = "select [First Name] from [CRONUS Sverige AB$Employee] where No_ in(select[Employee No_] from[CRONUS Sverige AB$Employee Absence] where[Cause of Absence Code]='SJUK' group by[Employee No_])";


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
        public List<CRONUS_Sverige_AB_Employee_Statistics_Group> GetAllEmployeeStatisticsGroup()
        {
            using (CronusContext cc = new CronusContext())
            {
                List<CRONUS_Sverige_AB_Employee_Statistics_Group> list = cc.CRONUS_Sverige_AB_Employee_Statistics_Group.ToList();
                return list;
            }
        }

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
