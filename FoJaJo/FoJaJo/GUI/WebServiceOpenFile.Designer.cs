using System.Windows.Forms;

namespace FoJaJo.GUI
{
    partial class webServiceOpenFile
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
            this.components = new System.ComponentModel.Container();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnShowPlayers = new System.Windows.Forms.Button();
            this.dataGridPlayers = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foJaJoDBDataSet = new FoJaJo.FoJaJoDBDataSet();
            this.playerTableAdapter = new FoJaJo.FoJaJoDBDataSetTableAdapters.PlayerTableAdapter();
            this.getAllPlayersResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foJaJoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllPlayersResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(663, 3);
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
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnShowPlayers
            // 
            this.btnShowPlayers.Location = new System.Drawing.Point(663, 264);
            this.btnShowPlayers.Name = "btnShowPlayers";
            this.btnShowPlayers.Size = new System.Drawing.Size(75, 23);
            this.btnShowPlayers.TabIndex = 3;
            this.btnShowPlayers.Text = "Show";
            this.btnShowPlayers.UseVisualStyleBackColor = true;
            this.btnShowPlayers.Click += new System.EventHandler(this.BtnShowPlayers_Click);
            // 
            // dataGridPlayers
            // 
            this.dataGridPlayers.AllowUserToAddRows = false;
            this.dataGridPlayers.AllowUserToDeleteRows = false;
            this.dataGridPlayers.AutoGenerateColumns = false;
            this.dataGridPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.totalWinsDataGridViewTextBoxColumn});
            this.dataGridPlayers.DataSource = this.playerBindingSource;
            this.dataGridPlayers.Location = new System.Drawing.Point(0, 267);
            this.dataGridPlayers.Name = "dataGridPlayers";
            this.dataGridPlayers.ReadOnly = true;
            this.dataGridPlayers.Size = new System.Drawing.Size(545, 241);
            this.dataGridPlayers.TabIndex = 4;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalWinsDataGridViewTextBoxColumn
            // 
            this.totalWinsDataGridViewTextBoxColumn.DataPropertyName = "TotalWins";
            this.totalWinsDataGridViewTextBoxColumn.HeaderText = "TotalWins";
            this.totalWinsDataGridViewTextBoxColumn.Name = "totalWinsDataGridViewTextBoxColumn";
            this.totalWinsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.foJaJoDBDataSet;
            // 
            // foJaJoDBDataSet
            // 
            this.foJaJoDBDataSet.DataSetName = "FoJaJoDBDataSet";
            this.foJaJoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // getAllPlayersResponseBindingSource
            // 
            this.getAllPlayersResponseBindingSource.DataSource = typeof(FoJaJo.FoJaJoWebService.GetAllPlayersResponse);
            // 
            // webServiceOpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridPlayers);
            this.Controls.Add(this.btnShowPlayers);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "webServiceOpenFile";
            this.Size = new System.Drawing.Size(741, 508);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foJaJoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllPlayersResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.BindingSource getAllPlayersResponseBindingSource;
        private System.Windows.Forms.Button btnShowPlayers;
        private System.Windows.Forms.DataGridView dataGridPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private FoJaJoDBDataSet foJaJoDBDataSet;
        private FoJaJoDBDataSetTableAdapters.PlayerTableAdapter playerTableAdapter;
    }
}
