using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoJaJo.Controller;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace FoJaJo.GUI
{
    public partial class ERPIntegration : UserControl
    {
        WebServiceController1 wc;
        public ERPIntegration()
        {
            InitializeComponent();
        }

        public StatusLabel StatusLbl { get; set; }

        private void ERPIntegration_Load(object sender, EventArgs e)
        {
            
        }

        private void TblLayOutERP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSelectERP_Click(object sender, EventArgs e)
        {
            wc = new WebServiceController1();
            dGVERP.DataSource = null;
            if(cBoxERP.SelectedIndex > -1)
            {
                switch(cBoxERP.SelectedIndex)
                {
                    case 0:
                        dGVERP.DataSource = wc.getMetaKeys();
                        break;
                    case 1:
                        dGVERP.DataSource = wc.getMetaIndexes();
                        break;
                    case 2:
                        dGVERP.DataSource = wc.getMetaTablesConstraints();
                        break;
                    case 3:
                        dGVERP.DataSource = wc.getMetaTables();
                        break;
                    case 4:
                        dGVERP.DataSource = wc.getMetaTables2();
                        break;
                    case 5:
                        dGVERP.DataSource = wc.GetMetaColumns();
                        break;
                    case 6:
                        dGVERP.DataSource = wc.GetMetaColumns2();
                        break;
                    case 7:
                        dGVERP.DataSource = wc.GetAllEmployees().Select(o => new
                        { o.First_Name, o.Job_Title, o.City }).ToList();
                        break;
                    case 8:
                        dGVERP.DataSource = wc.GetMetaColumns();
                        break;
                    case 9:
                        dGVERP.DataSource = wc.GetEmployeeRelatives();
                        break;
                    case 10:
                        dGVERP.DataSource = wc.GetEmployeeAbsence().Select(o => new {  o.Employee_No_,  o.Cause_of_Absence_Code, o.Description, From_Date = o.From_Date.ToString() }).ToList();
                        break;
                    case 11:
                        dGVERP.DataSource = wc.GetMostSick();
                        break;
                    case 12:
                        dGVERP.DataSource = wc.GetAllEmployeeAbsence().Select(o => new {  o.Entry_No_, o.Employee_No_, o.Cause_of_Absence_Code }).ToList();
                        break;
                    case 13:
                        dGVERP.DataSource = wc.GetAllPortalSetup().Select(o => new { o.Config_TP_Group_Capt_ID, o.Config_Tool_Pane_Caption, o.Search_Tool_Pane_Caption}).ToList();
                        break;
                    case 14:
                        dGVERP.DataSource = wc.GetAllQualification().Select(o => new { o.Description,  o.Qualification_Code, o.Institution_Company }).ToList();
                        break;
                }
            }
        }

        private void BtnDeleteCompany_Click(object sender, EventArgs e)
        {
            string companyName = txtBoxCompany.Text;
            if (companyName != null)
            {
                DialogResult dr = MessageBox.Show("Du kommer att ta bort företaget ur databasen", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        wc.RemoveCompany(companyName);
                        dGVERP.DataSource = null;
                        txtBoxCompany.Text = "";
                        txtBoxCompanyDescription.Text = "";
                        StatusLbl.Text = "Företaget borttaget!";
                    }
                    catch
                    {

                    }

                }
                else
                {
                    StatusLbl.Text = "Delete avbruten";
                }
            }
        }

        private void BtnAddCompany_Click(object sender, EventArgs e)
        {
            wc = new WebServiceController1();
            try
            {
                string text = txtBoxCompany.Text;
                string desc = txtBoxCompanyDescription.Text;
                if (text != null)
                {
                    wc.AddCompany(text, desc);
                    txtBoxCompany.Text = "";
                    txtBoxCompanyDescription.Text = "";
                }
                
            }
            catch (DbUpdateException sp)
            {
                MessageBox.Show("PK VIOLATION");
                Console.WriteLine("FELET ÄR:  " + sp.Message + "\n CODE: "+sp.HResult);
            }
            catch (SqlException mj)
            {
                MessageBox.Show("PK VIOLATION");
                Console.WriteLine("FELET ÄR:  " + mj.Message + "\n CODE: " + mj.HResult);
            }catch(Exception p)
            {
                Console.WriteLine("asd");
            }
        }

        private void BtnShowCompany_Click(object sender, EventArgs e)
        {
            string company = txtBoxCompany.Text;
            wc = new WebServiceController1();
            if (string.IsNullOrWhiteSpace(txtBoxCompany.Text))
            {
                try
                {
                    dGVERP.DataSource = wc.SelectAllCompany().Select(o => new { o.Name, o.Description }).ToList();
                }
                catch
                {

                }
            }
            else
            {
                try
                {
                    dGVERP.DataSource = wc.GetCompany(company).Select(o => new { o.Name, o.Description }).ToList();
                }
                catch
                {

                }
            }
        }

        private void BtnUpdateCompany_Click(object sender, EventArgs e)
        {
            string name = txtBoxCompany.Text;
            string desc = txtBoxCompanyDescription.Text;
            wc = new WebServiceController1();
            if (string.IsNullOrWhiteSpace(txtBoxCompanyDescription.Text) || string.IsNullOrWhiteSpace(txtBoxCompany.Text))
            {
                StatusLbl.Text = "Du måste fylla både Företag och description";
            }
            else
            {
                try
                {
                    wc.UpdateCompany(name, desc);
                    dGVERP.DataSource = wc.GetCompany(name).Select(o => new { o.Name, o.Description }).ToList();
                    txtBoxCompany.Text = "";
                    txtBoxCompanyDescription.Text = "";
                }
                catch
                {

                }
            }
        }
    }
}
