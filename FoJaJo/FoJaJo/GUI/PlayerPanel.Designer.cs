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
            this.loginControl = new FoJaJo.GUI.LoginControl();
            this.playerInfoControl = new FoJaJo.GUI.PlayerInfoControl();
            this.SuspendLayout();
            // 
            // loginControl
            // 
            this.loginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControl.Location = new System.Drawing.Point(0, 0);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(394, 302);
            this.loginControl.TabIndex = 1;
            // 
            // playerInfoControl
            // 
            this.playerInfoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerInfoControl.Location = new System.Drawing.Point(0, 0);
            this.playerInfoControl.Name = "playerInfoControl";
            this.playerInfoControl.Size = new System.Drawing.Size(394, 302);
            this.playerInfoControl.TabIndex = 0;
            // 
            // PlayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginControl);
            this.Controls.Add(this.playerInfoControl);
            this.Name = "PlayerPanel";
            this.Size = new System.Drawing.Size(394, 302);
            this.ResumeLayout(false);

        }

        #endregion

        private PlayerInfoControl playerInfoControl;
        private LoginControl loginControl;
    }
}
