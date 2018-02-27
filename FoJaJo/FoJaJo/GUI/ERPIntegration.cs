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

namespace FoJaJo.GUI
{
    public partial class ERPIntegration : UserControl
    {
        WebServiceController1 wc;
        public ERPIntegration()
        {
            InitializeComponent();
        }

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
                        MessageBox.Show("EMPLOYEEE");
                        //dGVERP.DataSource = wc.();
                        break;
                    case 8:
                       // dGVERP.DataSource = wc.getMetaIndexes();
                        break;
                    case 9:
                        dGVERP.DataSource = wc.getEmployeeRelatives();
                        break;
                    case 10:
                        //dGVERP.DataSource = wc.getMetaIndexes();
                        break;
                    case 11:
                        //dGVERP.DataSource = wc.getMetaIndexes();
                        break;


                }
            }
        }

        private void BtnDeleteCompany_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Du kommer att ta bort företaget ur databasen","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void BtnAddCompany_Click(object sender, EventArgs e)
        {
            wc = new WebServiceController1();
            try
            {
                string text = txtBoxCompany.Text;
                wc.InsertCompany(text);
                txtBoxCompany.Text = "";
            }
            catch
            {

            }
        }
    }
}
