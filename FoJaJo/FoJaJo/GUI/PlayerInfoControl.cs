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
        public PlayerController Controller { get; set; }
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
            if (Controller.LogOutPlayer())
                (Parent as PlayerPanel).CurrentPlayer = null;
        }
    }
}
