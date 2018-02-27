﻿using System.Windows.Forms;

namespace FoJaJo.GUI
{
    partial class ERPIntegration
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblLayOutERP = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.btnShowCompany = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.lblNewCompanyName = new System.Windows.Forms.Label();
            this.txtBoxUpdateCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtBoxCompany = new System.Windows.Forms.TextBox();
            this.cBoxERP = new System.Windows.Forms.ComboBox();
            this.btnSelectERP = new System.Windows.Forms.Button();
            this.dGVERP = new System.Windows.Forms.DataGridView();
            this.tblLayOutERP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVERP)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayOutERP
            // 
            this.tblLayOutERP.ColumnCount = 2;
            this.tblLayOutERP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.76923F));
            this.tblLayOutERP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.23077F));
            this.tblLayOutERP.Controls.Add(this.btnDeleteCompany, 1, 8);
            this.tblLayOutERP.Controls.Add(this.btnUpdateCompany, 0, 8);
            this.tblLayOutERP.Controls.Add(this.btnShowCompany, 0, 7);
            this.tblLayOutERP.Controls.Add(this.btnAddCompany, 1, 7);
            this.tblLayOutERP.Controls.Add(this.lblNewCompanyName, 0, 6);
            this.tblLayOutERP.Controls.Add(this.txtBoxUpdateCompanyName, 1, 6);
            this.tblLayOutERP.Controls.Add(this.lblCompanyName, 0, 5);
            this.tblLayOutERP.Controls.Add(this.txtBoxCompany, 1, 5);
            this.tblLayOutERP.Controls.Add(this.cBoxERP, 0, 0);
            this.tblLayOutERP.Controls.Add(this.btnSelectERP, 0, 1);
            this.tblLayOutERP.Dock = System.Windows.Forms.DockStyle.Left;
            this.tblLayOutERP.Location = new System.Drawing.Point(0, 0);
            this.tblLayOutERP.Name = "tblLayOutERP";
            this.tblLayOutERP.RowCount = 10;
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.333333F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.66667F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.5F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.666667F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.666667F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayOutERP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayOutERP.Size = new System.Drawing.Size(242, 600);
            this.tblLayOutERP.TabIndex = 11;
            this.tblLayOutERP.Paint += new System.Windows.Forms.PaintEventHandler(this.TblLayOutERP_Paint);
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Location = new System.Drawing.Point(101, 512);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(96, 23);
            this.btnDeleteCompany.TabIndex = 18;
            this.btnDeleteCompany.Text = "Ta Bort";
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            this.btnDeleteCompany.Click += new System.EventHandler(this.BtnDeleteCompany_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Location = new System.Drawing.Point(3, 512);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(92, 23);
            this.btnUpdateCompany.TabIndex = 19;
            this.btnUpdateCompany.Text = "Uppdatera";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            // 
            // btnShowCompany
            // 
            this.btnShowCompany.Location = new System.Drawing.Point(3, 482);
            this.btnShowCompany.Name = "btnShowCompany";
            this.btnShowCompany.Size = new System.Drawing.Size(92, 23);
            this.btnShowCompany.TabIndex = 17;
            this.btnShowCompany.Text = "Visa";
            this.btnShowCompany.UseVisualStyleBackColor = true;
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(101, 482);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(96, 23);
            this.btnAddCompany.TabIndex = 21;
            this.btnAddCompany.Text = "Lägg till";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.BtnAddCompany_Click);
            // 
            // lblNewCompanyName
            // 
            this.lblNewCompanyName.AutoSize = true;
            this.lblNewCompanyName.Location = new System.Drawing.Point(3, 451);
            this.lblNewCompanyName.Name = "lblNewCompanyName";
            this.lblNewCompanyName.Size = new System.Drawing.Size(58, 13);
            this.lblNewCompanyName.TabIndex = 15;
            this.lblNewCompanyName.Text = "Nytt namn:";
            // 
            // txtBoxUpdateCompanyName
            // 
            this.txtBoxUpdateCompanyName.Location = new System.Drawing.Point(101, 454);
            this.txtBoxUpdateCompanyName.Name = "txtBoxUpdateCompanyName";
            this.txtBoxUpdateCompanyName.Size = new System.Drawing.Size(138, 20);
            this.txtBoxUpdateCompanyName.TabIndex = 20;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(3, 423);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(84, 13);
            this.lblCompanyName.TabIndex = 14;
            this.lblCompanyName.Text = "Företagsnamn: *";
            // 
            // txtBoxCompany
            // 
            this.txtBoxCompany.Location = new System.Drawing.Point(101, 426);
            this.txtBoxCompany.Name = "txtBoxCompany";
            this.txtBoxCompany.Size = new System.Drawing.Size(138, 20);
            this.txtBoxCompany.TabIndex = 16;
            // 
            // cBoxERP
            // 
            this.tblLayOutERP.SetColumnSpan(this.cBoxERP, 2);
            this.cBoxERP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxERP.FormattingEnabled = true;
            this.cBoxERP.Items.AddRange(new object[] {
            "Nycklar",
            "Indexes",
            "Table constraints",
            "Alla tabeller1",
            "Alla tabeller2",
            "Alla kolumner1",
            "Alla kolumner2",
            "Employee",
            "MetadataEmployee",
            "Personal och släkt",
            "Sjuka2004",
            "Mest sjuka"});
            this.cBoxERP.Location = new System.Drawing.Point(3, 3);
            this.cBoxERP.Name = "cBoxERP";
            this.cBoxERP.Size = new System.Drawing.Size(170, 21);
            this.cBoxERP.TabIndex = 13;
            this.cBoxERP.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // btnSelectERP
            // 
            this.btnSelectERP.Location = new System.Drawing.Point(3, 29);
            this.btnSelectERP.Name = "btnSelectERP";
            this.btnSelectERP.Size = new System.Drawing.Size(75, 23);
            this.btnSelectERP.TabIndex = 12;
            this.btnSelectERP.Text = "Visa";
            this.btnSelectERP.UseVisualStyleBackColor = true;
            this.btnSelectERP.Click += new System.EventHandler(this.BtnSelectERP_Click);
            // 
            // dGVERP
            // 
            this.dGVERP.AllowUserToAddRows = false;
            this.dGVERP.AllowUserToDeleteRows = false;
            this.dGVERP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGVERP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVERP.Dock = System.Windows.Forms.DockStyle.Right;
            this.dGVERP.Location = new System.Drawing.Point(245, 0);
            this.dGVERP.Name = "dGVERP";
            this.dGVERP.ReadOnly = true;
            this.dGVERP.Size = new System.Drawing.Size(512, 600);
            this.dGVERP.TabIndex = 12;
            // 
            // ERPIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGVERP);
            this.Controls.Add(this.tblLayOutERP);
            this.Name = "ERPIntegration";
            this.Size = new System.Drawing.Size(757, 600);
            this.Load += new System.EventHandler(this.ERPIntegration_Load);
            this.tblLayOutERP.ResumeLayout(false);
            this.tblLayOutERP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVERP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayOutERP;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Button btnShowCompany;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Label lblNewCompanyName;
        private System.Windows.Forms.TextBox txtBoxUpdateCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtBoxCompany;
        private System.Windows.Forms.ComboBox cBoxERP;
        private System.Windows.Forms.Button btnSelectERP;
        private System.Windows.Forms.DataGridView dGVERP;
    }
}