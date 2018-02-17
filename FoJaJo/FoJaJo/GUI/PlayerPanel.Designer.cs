namespace FoJaJo.GUI
{
    partial class PlayerPanel
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
            this.playerInfoControl1 = new FoJaJo.GUI.PlayerInfoControl();
            this.loginControl1 = new FoJaJo.GUI.LoginControl();
            this.SuspendLayout();
            // 
            // playerInfoControl1
            // 
            this.playerInfoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerInfoControl1.Location = new System.Drawing.Point(0, 0);
            this.playerInfoControl1.Name = "playerInfoControl1";
            this.playerInfoControl1.Size = new System.Drawing.Size(394, 302);
            this.playerInfoControl1.TabIndex = 0;
            // 
            // loginControl1
            // 
            this.loginControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControl1.Location = new System.Drawing.Point(0, 0);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(394, 302);
            this.loginControl1.TabIndex = 1;
            // 
            // PlayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.playerInfoControl1);
            this.Name = "PlayerPanel";
            this.Size = new System.Drawing.Size(394, 302);
            this.ResumeLayout(false);

        }

        #endregion

        private PlayerInfoControl playerInfoControl1;
        private LoginControl loginControl1;
    }
}
