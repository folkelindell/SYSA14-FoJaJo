﻿namespace FoJaJo.GUI
{
    partial class RootForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.luffarRootControl1 = new FoJaJo.GUI.LuffarRootControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileShowPlayers1 = new FoJaJo.GUI.OpenFileShowPlayers();
            this.statusLabel1 = new FoJaJo.GUI.StatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.erpIntegration1 = new FoJaJo.GUI.ERPIntegration();
            this.playerTableAdapter1 = new FoJaJo.FoJaJoDBDataSetTableAdapters.PlayerTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 655);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.luffarRootControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // luffarRootControl1
            // 
            this.luffarRootControl1.Controller = null;
            this.luffarRootControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luffarRootControl1.Location = new System.Drawing.Point(3, 3);
            this.luffarRootControl1.Name = "luffarRootControl1";
            this.luffarRootControl1.Size = new System.Drawing.Size(882, 623);
            this.luffarRootControl1.Status = null;
            this.luffarRootControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.openFileShowPlayers1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileShowPlayers1
            // 
            this.openFileShowPlayers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openFileShowPlayers1.Location = new System.Drawing.Point(3, 3);
            this.openFileShowPlayers1.Name = "openFileShowPlayers1";
            this.openFileShowPlayers1.Size = new System.Drawing.Size(849, 632);
            this.openFileShowPlayers1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.erpIntegration1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(855, 638);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // erpIntegration1
            // 
            this.erpIntegration1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.erpIntegration1.Location = new System.Drawing.Point(3, 3);
            this.erpIntegration1.Name = "erpIntegration1";
            this.erpIntegration1.Size = new System.Drawing.Size(849, 632);
            this.erpIntegration1.TabIndex = 0;
            // 
            // playerTableAdapter1
            // statusLabel1
            // 
            this.statusLabel1.AutoSize = true;
            this.statusLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel1.Location = new System.Drawing.Point(3, 661);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(896, 20);
            this.statusLabel1.TabIndex = 1;
            this.statusLabel1.Text = "statusLabel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusLabel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 681);
            this.tableLayoutPanel1.TabIndex = 2;
            this.playerTableAdapter1.ClearBeforeFill = true;
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RootForm";
            this.Text = "RootForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private LuffarRootControl luffarRootControl1;
        private OpenFileShowPlayers openFileShowPlayers1;
        private System.Windows.Forms.TabPage tabPage3;
        private FoJaJoDBDataSetTableAdapters.PlayerTableAdapter playerTableAdapter1;
        private ERPIntegration erpIntegration1;
        private StatusLabel statusLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}