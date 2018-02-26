using System.Windows.Forms;

namespace FoJaJo.GUI
{
    partial class OpenFileShowPlayers
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnShowPlayers = new System.Windows.Forms.Button();
            this.dataGridGetAllPlayers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGetAllPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(551, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(0, 0);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox.Size = new System.Drawing.Size(545, 258);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextChanged += new System.EventHandler(this.TxtBoxOpenFile_TextChanged);
            // 
            // btnShowPlayers
            // 
            this.btnShowPlayers.Location = new System.Drawing.Point(551, 267);
            this.btnShowPlayers.Name = "btnShowPlayers";
            this.btnShowPlayers.Size = new System.Drawing.Size(75, 23);
            this.btnShowPlayers.TabIndex = 3;
            this.btnShowPlayers.Text = "Show";
            this.btnShowPlayers.UseVisualStyleBackColor = true;
            this.btnShowPlayers.Click += new System.EventHandler(this.BtnShowPlayers_Click);
            // 
            // dataGridGetAllPlayers
            // 
            this.dataGridGetAllPlayers.AllowUserToAddRows = false;
            this.dataGridGetAllPlayers.AllowUserToDeleteRows = false;
            this.dataGridGetAllPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGetAllPlayers.Location = new System.Drawing.Point(3, 264);
            this.dataGridGetAllPlayers.Name = "dataGridGetAllPlayers";
            this.dataGridGetAllPlayers.ReadOnly = true;
            this.dataGridGetAllPlayers.Size = new System.Drawing.Size(541, 246);
            this.dataGridGetAllPlayers.TabIndex = 4;
            // 
            // OpenFileShowPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridGetAllPlayers);
            this.Controls.Add(this.btnShowPlayers);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "OpenFileShowPlayers";
            this.Size = new System.Drawing.Size(631, 511);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGetAllPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnShowPlayers;
        private DataGridView dataGridGetAllPlayers;
    }
}
