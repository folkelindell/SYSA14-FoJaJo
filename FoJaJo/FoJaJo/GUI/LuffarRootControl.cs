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
        public GameController Controller { get; set; }
        public LuffarRootControl()
        {
            InitializeComponent();
            Controller = new GameController();
            Controller.GameWon += this.GameWon;
            gameControl.Controller = Controller;
            playerOnePanel.Controller = Controller;
            playerTwoPanel.Controller = Controller;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Controller.NewGame(playerOnePanel.CurrentPlayer, playerTwoPanel.CurrentPlayer, 20, 20);
        }

        public void GameWon()
        {
            MessageBox.Show(Controller.BoardState.CurrentPlayer.Username + " WON!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.None);
            gameControl.Enabled = false;
        }
    }
}
