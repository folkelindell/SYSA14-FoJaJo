﻿namespace FoJaJo.GUI
{
    partial class LuffarRootControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newGameButton = new System.Windows.Forms.Button();
            this.p1 = new FoJaJo.GUI.PlayerPanel();
            this.playerPanel1 = new FoJaJo.GUI.PlayerPanel();
            this.gameControl1 = new FoJaJo.GUI.GameControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 620F));
            this.tableLayoutPanel1.Controls.Add(this.p1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameControl1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.newGameButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.64135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.35865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 639);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // newGameButton
            // 
            this.newGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGameButton.Location = new System.Drawing.Point(23, 254);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(185, 62);
            this.newGameButton.TabIndex = 3;
            this.newGameButton.Text = "Go";
            this.newGameButton.UseVisualStyleBackColor = true;
            // 
            // p1
            // 
            this.p1.CurrentPlayer = null;
            this.p1.Location = new System.Drawing.Point(23, 322);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(185, 210);
            this.p1.TabIndex = 0;
            // 
            // playerPanel1
            // 
            this.playerPanel1.CurrentPlayer = null;
            this.playerPanel1.Location = new System.Drawing.Point(23, 14);
            this.playerPanel1.Name = "playerPanel1";
            this.playerPanel1.Size = new System.Drawing.Size(185, 220);
            this.playerPanel1.TabIndex = 1;
            // 
            // gameControl1
            // 
            this.gameControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameControl1.Location = new System.Drawing.Point(229, 14);
            this.gameControl1.Name = "gameControl1";
            this.tableLayoutPanel1.SetRowSpan(this.gameControl1, 3);
            this.gameControl1.Size = new System.Drawing.Size(614, 606);
            this.gameControl1.TabIndex = 2;
            // 
            // LuffarRootControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LuffarRootControl";
            this.Size = new System.Drawing.Size(846, 639);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PlayerPanel p1;
        private PlayerPanel playerPanel1;
        private GameControl gameControl1;
        private System.Windows.Forms.Button newGameButton;
    }
}