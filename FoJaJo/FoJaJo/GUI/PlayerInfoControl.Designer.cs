namespace FoJaJo.GUI
{
    partial class PlayerInfoControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameValue = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.ratingValue = new System.Windows.Forms.Label();
            this.totalWinsLabel = new System.Windows.Forms.Label();
            this.totalWinsValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.84849F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ratingLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.logoutButton, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.ratingValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.totalWinsLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.totalWinsValue, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameLabel, 2);
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Location = new System.Drawing.Point(35, 18);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(265, 27);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // usernameValue
            // 
            this.usernameValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameValue, 2);
            this.usernameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameValue.Location = new System.Drawing.Point(35, 45);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(265, 32);
            this.usernameValue.TabIndex = 1;
            this.usernameValue.Text = "usernameValue";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ratingLabel, 2);
            this.ratingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratingLabel.Location = new System.Drawing.Point(35, 77);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(265, 33);
            this.ratingLabel.TabIndex = 2;
            this.ratingLabel.Text = "Rating";
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutButton.Location = new System.Drawing.Point(216, 195);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(84, 27);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ratingValue
            // 
            this.ratingValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ratingValue, 2);
            this.ratingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratingValue.Location = new System.Drawing.Point(35, 110);
            this.ratingValue.Name = "ratingValue";
            this.ratingValue.Size = new System.Drawing.Size(265, 32);
            this.ratingValue.TabIndex = 4;
            this.ratingValue.Text = "ratingValue";
            // 
            // totalWinsLabel
            // 
            this.totalWinsLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.totalWinsLabel, 2);
            this.totalWinsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalWinsLabel.Location = new System.Drawing.Point(35, 142);
            this.totalWinsLabel.Name = "totalWinsLabel";
            this.totalWinsLabel.Size = new System.Drawing.Size(265, 26);
            this.totalWinsLabel.TabIndex = 5;
            this.totalWinsLabel.Text = "Total wins";
            // 
            // totalWinsValue
            // 
            this.totalWinsValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.totalWinsValue, 2);
            this.totalWinsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalWinsValue.Location = new System.Drawing.Point(35, 168);
            this.totalWinsValue.Name = "totalWinsValue";
            this.totalWinsValue.Size = new System.Drawing.Size(265, 24);
            this.totalWinsValue.TabIndex = 6;
            this.totalWinsValue.Text = "totalWinsLabel";
            // 
            // PlayerInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlayerInfoControl";
            this.Size = new System.Drawing.Size(328, 246);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label usernameValue;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label ratingValue;
        private System.Windows.Forms.Label totalWinsLabel;
        private System.Windows.Forms.Label totalWinsValue;
    }
}
