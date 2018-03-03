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
        public ERPIntegration()
        {
            InitializeComponent();
        }

        public StatusLabel StatusLbl { get; set; }
        public WebServiceController1 WebController { get; set; }

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
            dGVERP.DataSource = null;
            if(cBoxERP.SelectedIndex > -1)
            {
                try
                {
                    switch (cBoxERP.SelectedIndex)
                    {
                        case 0:
                            dGVERP.DataSource = WebController.getMetaKeys();
                            break;
                        case 1:
                            dGVERP.DataSource = WebController.getMetaIndexes();
                            break;
                        case 2:
                            dGVERP.DataSource = WebController.getMetaTablesConstraints();
                            break;
                        case 3:
                            dGVERP.DataSource = WebController.getMetaTables();
                            break;
                        case 4:
                            dGVERP.DataSource = WebController.getMetaTables2();
                            break;
                        case 5:
                            dGVERP.DataSource = WebController.GetMetaColumns();
                            break;
                        case 6:
                            dGVERP.DataSource = WebController.GetMetaColumns2();
                            break;
                        case 7:
                            dGVERP.DataSource = WebController.GetAllEmployees().Select(o => new
                            { o.First_Name, o.Job_Title, o.City }).ToList();
                            break;
                        case 8:
                            dGVERP.DataSource = WebController.GetMetaColumns();
                            break;
                        case 9:
                            dGVERP.DataSource = WebController.GetEmployeeRelatives();
                            break;
                        case 10:
                            dGVERP.DataSource = WebController.GetEmployeeAbsence().Select(o => new { o.Employee_No_, o.Cause_of_Absence_Code, o.Description, From_Date = o.From_Date.ToString() }).ToList();
                            break;
                        case 11:
                            dGVERP.DataSource = WebController.GetMostSick();
                            break;
                        case 12:
                            dGVERP.DataSource = WebController.GetAllEmployeeAbsence().Select(o => new { o.Entry_No_, o.Employee_No_, o.Cause_of_Absence_Code }).ToList();
                            break;
                        case 13:
                            dGVERP.DataSource = WebController.GetAllPortalSetup().Select(o => new { o.Config_TP_Group_Capt_ID, o.Config_Tool_Pane_Caption, o.Search_Tool_Pane_Caption }).ToList();
                            break;
                        case 14:
                            dGVERP.DataSource = WebController.GetAllQualification().Select(o => new { o.Description, o.Qualification_Code, o.Institution_Company }).ToList();
                            break;
                    }
                }catch (Exception x)
                {
                    StatusLbl.ShowMessage(x.Message);
                }
            }
        }

        private void BtnDeleteCompany_Click(object sender, EventArgs e)
        {
            string companyName = txtBoxCompany.Text;
            if (companyName != null)
            {
                DialogResult dr = MessageBox.Show("You will permanently remove the company from the database", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        WebController.RemoveCompany(companyName);
                        dGVERP.DataSource = null;
                        txtBoxCompany.Text = "";
                        txtBoxCompanyDescription.Text = "";
                        StatusLbl.ShowStatus("Company deleted!");
                    }
                    catch (Exception x)
                    {
                        StatusLbl.ShowMessage(x.Message);
                    }

                }
                else
                {
                    StatusLbl.ShowMessage("Delete cancelled");
                }
            }
        }

        private void BtnAddCompany_Click(object sender, EventArgs e)
        {
            string text = txtBoxCompany.Text;
            string desc = txtBoxCompanyDescription.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(txtBoxCompany.Text) || string.IsNullOrWhiteSpace(txtBoxCompanyDescription.Text))
                {
                    StatusLbl.ShowMessage("You need to fill both name and description");
                }
                else
                {
                    WebController.AddCompany(text, desc);
                    txtBoxCompany.Text = "";
                    txtBoxCompanyDescription.Text = "";
                }
            }catch(Exception p)
            {
                StatusLbl.ShowMessage(p.Message + text);
            }
        }

        private void BtnShowCompany_Click(object sender, EventArgs e)
        {
            string company = txtBoxCompany.Text;
            if (string.IsNullOrWhiteSpace(txtBoxCompany.Text))
            {
                try
                {
                    dGVERP.DataSource = WebController.SelectAllCompany().Select(o => new { o.Name, o.Description }).ToList();
                }
                catch(Exception x)
                {
                    StatusLbl.ShowMessage(x.Message);
                }
            }
            else
            {
                try
                {
                    dGVERP.DataSource = WebController.GetCompany(company).Select(o => new { o.Name, o.Description }).ToList();
                }
                catch(Exception x)
                {
                    StatusLbl.ShowMessage(x.Message);
                }
            }
        }

        private void BtnUpdateCompany_Click(object sender, EventArgs e)
        {
            string name = txtBoxCompany.Text;
            string desc = txtBoxCompanyDescription.Text;
            if (string.IsNullOrWhiteSpace(txtBoxCompanyDescription.Text) || string.IsNullOrWhiteSpace(txtBoxCompany.Text))
            {
                StatusLbl.ShowMessage("You need to fill both name and description");
            }
            else
            {
                try
                {
                    WebController.UpdateCompany(name, desc);
                    dGVERP.DataSource = WebController.GetCompany(name).Select(o => new { o.Name, o.Description }).ToList();
                    txtBoxCompany.Text = "";
                    txtBoxCompanyDescription.Text = "";
                    StatusLbl.ShowStatus("Update success!");
                }
                catch (Exception x)
                {
                    StatusLbl.ShowMessage(x.Message);
                }
            }
        }
    }
}
