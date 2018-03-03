using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoJaJo.Controller;
using FoJaJo.GUI;
using FoJaJo.Model;

namespace FoJaJo.GUI
{
    public partial class LuffarRootControl : UserControl
    {
        private StatusLabel status;
        public StatusLabel Status
        {
            get { return status; }
            set { status = value;
                playerOnePanel.Status = Status;
                playerTwoPanel.Status = Status;
                gameControl.Status = Status;
            }
        }
        private GameController controller;
        public GameController Controller { get
            {
                return controller;
            }
            set
            {
                controller = value;
                gameControl.Controller = Controller;
                playerOnePanel.Controller = Controller;
                playerTwoPanel.Controller = Controller;
                if (controller != null) Controller.OnGameWon += this.GameWonEvent;
            }
        }
        public LuffarRootControl()
        {
            InitializeComponent();
            
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Controller.NewGame(playerOnePanel.CurrentPlayer, playerTwoPanel.CurrentPlayer, 20, 20);
        }

        private void GameWonEvent()
        {
            Status.ShowStatus(Controller.BoardState.CurrentPlayer.Username + " won!");
            MessageBox.Show(Controller.BoardState.CurrentPlayer.Username + " WON!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.None);
            gameControl.Enabled = false;
        }
    }
}
