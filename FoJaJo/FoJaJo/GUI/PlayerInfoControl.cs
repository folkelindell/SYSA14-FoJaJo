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
    public partial class PlayerInfoControl : UserControl
    {
        public StatusLabel Status { get; set; }
        private GameController controller;
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
                    controller.GameStarted += NewGameBoard;
            }
        }
        private GameBoardState boardState;
        public GameBoardState BoardState
        {
            get
            {
                return boardState;
            }
            set
            {
                boardState = value;
                if (boardState != null)
                    boardState.GameBoardChanged += this.UpdateView;
                UpdateView();
            }
        }
        private Player currentPlayer;
        public Player CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }
            set
            {
                currentPlayer = value;
                usernameValue.Text = currentPlayer?.Username;
                ratingValue.Text = currentPlayer?.Rating.ToString();
                totalWinsValue.Text = currentPlayer?.TotalWins.ToString();
            }
        }
        public PlayerInfoControl()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if ((Parent as PlayerPanel).Controller.LogOutPlayer())
            {
                Status.ShowStatus((Parent as PlayerPanel).CurrentPlayer.Username + " logged out.");
                (Parent as PlayerPanel).CurrentPlayer = null;
            }
        }
        public void UpdateView()
        {
            if (BoardState != null && BoardState.CurrentPlayer.Equals(CurrentPlayer))
            {
                BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                BorderStyle = BorderStyle.None;
            }
        }

        public void NewGameBoard()
        {
            BorderStyle = BorderStyle.None;
            BoardState = Controller.BoardState;
        }
    }
}
