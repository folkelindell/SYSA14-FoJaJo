using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoJaJo.Controller;

namespace FoJaJo.GUI
{
    public partial class GameBoardControl : UserControl
    {
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Button[,] board;
        public GameController gameController { get; set; }
        public GameBoardControl()
        {
            int x = 20;
            int y = 20;
            InitializeComponent();
            betterInit(x, y);
        }

        private void betterInit(int x, int y)
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = x;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = y;
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Margin = Padding.Empty;

            createSquares(x, y);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameBoardControl";
            this.Size = new System.Drawing.Size(363, 339);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void createSquares(int x, int y)
        {
            board = new SquareControl[x, y];
            for (int a = 0; a < x; a++)
            {
                for (int b = 0; b < y; b++)
                {
                    board[a, b] = new SquareControl(a, b);
                    tableLayoutPanel1.Controls.Add(board[a, b], a, b);
                }
            }
        }
    }
}
