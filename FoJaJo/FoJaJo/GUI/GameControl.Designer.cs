namespace FoJaJo.GUI
{
    partial class GameControl
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
            this.gameBoardControl1 = new FoJaJo.GUI.GameBoardControl();
            this.SuspendLayout();
            // 
            // gameBoardControl1
            // 
            this.gameBoardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBoardControl1.Location = new System.Drawing.Point(0, 0);
            this.gameBoardControl1.Name = "gameBoardControl1";
            this.gameBoardControl1.Size = new System.Drawing.Size(150, 150);
            this.gameBoardControl1.TabIndex = 0;
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gameBoardControl1);
            this.Name = "GameControl";
            this.ResumeLayout(false);

        }

        #endregion

        private GameBoardControl gameBoardControl1;
    }
}
