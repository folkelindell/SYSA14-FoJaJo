using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoJaJo.GUI;
using FoJaJo.Controller;
using FoJaJo.Model;

namespace FoJaJo.GUI
{
    public partial class PlayerPanel : UserControl
    {
        private GameController controller;
        public GameController Controller { get
            {
                return controller;
            }
            set
            {
                controller = value;
                playerInfoControl.Controller = value;
            }
        }
        private Player currentPlayer;
        public Player CurrentPlayer { get
            {
                return currentPlayer;
            }
            set
            {
                currentPlayer = value;
                if(currentPlayer != null)
                {
                    loginControl.Hide();
                    playerInfoControl.CurrentPlayer = currentPlayer;
                    playerInfoControl.Show();
                }
                else
                {
                    playerInfoControl.CurrentPlayer = currentPlayer;
                    playerInfoControl.Hide();
                    loginControl.Show();
                }
            }
        }
        public PlayerPanel()
        {
            InitializeComponent();
        }
    }
}
