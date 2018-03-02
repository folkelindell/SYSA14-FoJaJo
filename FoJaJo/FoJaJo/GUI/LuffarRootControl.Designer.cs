namespace FoJaJo.GUI
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
            this.playerTwoPanel = new FoJaJo.GUI.PlayerPanel();
            this.playerOnePanel = new FoJaJo.GUI.PlayerPanel();
            this.gameControl = new FoJaJo.GUI.GameBoardControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Controls.Add(this.playerTwoPanel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerOnePanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameControl, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.newGameButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // newGameButton
            // 
            this.newGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGameButton.Location = new System.Drawing.Point(23, 296);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(234, 44);
            this.newGameButton.TabIndex = 3;
            this.newGameButton.Text = "Go";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // playerTwoPanel
            // 
            this.playerTwoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerTwoPanel.Controller = null;
            this.playerTwoPanel.CurrentPlayer = null;
            this.playerTwoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerTwoPanel.Location = new System.Drawing.Point(23, 346);
            this.playerTwoPanel.Name = "playerTwoPanel";
            this.playerTwoPanel.Size = new System.Drawing.Size(234, 267);
            this.playerTwoPanel.Status = null;
            this.playerTwoPanel.TabIndex = 0;
            // 
            // playerOnePanel
            // 
            this.playerOnePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerOnePanel.Controller = null;
            this.playerOnePanel.CurrentPlayer = null;
            this.playerOnePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerOnePanel.Location = new System.Drawing.Point(23, 23);
            this.playerOnePanel.Name = "playerOnePanel";
            this.playerOnePanel.Size = new System.Drawing.Size(234, 267);
            this.playerOnePanel.Status = null;
            this.playerOnePanel.TabIndex = 1;
            // 
            // gameControl
            // 
            this.gameControl.BoardState = null;
            this.gameControl.Controller = null;
            this.gameControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameControl.Enabled = false;
            this.gameControl.Location = new System.Drawing.Point(283, 23);
            this.gameControl.Name = "gameControl";
            this.tableLayoutPanel1.SetRowSpan(this.gameControl, 3);
            this.gameControl.Size = new System.Drawing.Size(555, 590);
            this.gameControl.TabIndex = 2;
            // 
            // LuffarRootControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LuffarRootControl";
            this.Size = new System.Drawing.Size(866, 637);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PlayerPanel playerTwoPanel;
        private PlayerPanel playerOnePanel;
        private GameBoardControl gameControl;
        private System.Windows.Forms.Button newGameButton;
    }
}