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
using FoJaJo.Model;

namespace FoJaJo.GUI
{
    public partial class GameBoardControl : UserControl
    {
        private SquareControl[,] board;
        public StatusLabel Status { get; set; }
        public GameController controller;
        public GameController Controller
        {
            get
            {
                return controller;
            }
            set
            {
                controller = value;
                if (controller != null)
                {
                    controller.GameStarted += UpdateView;
                }
            }
        }
        public GameBoardState BoardState { get; set; }
        public GameBoardControl()
        {
            InitializeComponent();
            Enabled = false;
        }

        public void CreateBoard()
        {
            this.squareGrid.SuspendLayout();
            this.SuspendLayout();
            this.squareGrid.ColumnStyles.Clear();

            this.squareGrid.Controls.Clear();

            CreateSquares();

            this.squareGrid.ResumeLayout(true);
            this.ResumeLayout(true);
        }

        private void CreateSquares()
        {
            board = new SquareControl[BoardState.XDim, BoardState.YDim];
            for (int a = 0; a < BoardState.XDim; a++)
            {
                for (int b = 0; b < BoardState.YDim; b++)
                {
                    board[a, b] = new SquareControl(a, b, BoardState.BoardValues[a, b])
                    {
                        Controller = Controller
                    };
                    squareGrid.Controls.Add(board[a, b], a, b);
                }
            }
        }

        public void UpdateView()
        {
            if (Controller.BoardState == null)
            {
                squareGrid.Controls.Clear();
            }
            else if (!Controller.BoardState.Equals(BoardState))
            {
                BoardState = Controller.BoardState;
                CreateBoard();
                Status.ShowStatus("Game started!");
                Enabled = true;
            }
        }
    }
}
