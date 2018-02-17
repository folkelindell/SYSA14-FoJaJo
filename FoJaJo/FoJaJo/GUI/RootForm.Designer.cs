namespace FoJaJo.GUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playerPanel1 = new FoJaJo.GUI.PlayerPanel();
            this.playerInfoControl1 = new FoJaJo.GUI.PlayerInfoControl();
            this.playerPanel2 = new FoJaJo.GUI.PlayerPanel();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.playerPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerInfoControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.gameControl1, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.64135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.35865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // playerPanel1
            // 
            this.playerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerPanel1.Location = new System.Drawing.Point(23, 14);
            this.playerPanel1.Name = "playerPanel1";
            this.playerPanel1.Size = new System.Drawing.Size(185, 220);
            this.playerPanel1.TabIndex = 0;
            // 
            // playerInfoControl1
            // 
            this.playerInfoControl1.Location = new System.Drawing.Point(3, 3);
            this.playerInfoControl1.Name = "playerInfoControl1";
            this.playerInfoControl1.Size = new System.Drawing.Size(14, 5);
            this.playerInfoControl1.TabIndex = 1;
            // 
            // playerPanel2
            // 
            this.playerPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerPanel2.Location = new System.Drawing.Point(23, 250);
            this.playerPanel2.Name = "playerPanel2";
            this.playerPanel2.Size = new System.Drawing.Size(185, 210);
            this.playerPanel2.TabIndex = 2;
            // 
            // gameControl1
            // 
            this.gameControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameControl1.Location = new System.Drawing.Point(229, 14);
            this.gameControl1.Name = "gameControl1";
            this.tableLayoutPanel1.SetRowSpan(this.gameControl1, 3);
            this.gameControl1.Size = new System.Drawing.Size(463, 446);
            this.gameControl1.TabIndex = 3;
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RootForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GUI.PlayerPanel playerPanel1;
        private GUI.PlayerInfoControl playerInfoControl1;
        private GUI.PlayerPanel playerPanel2;
        private GameControl gameControl1;
    }
}