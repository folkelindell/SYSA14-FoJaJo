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
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Player player = (Parent as PlayerPanel).Controller.LogInPlayer(usernameInput.Text, passwordInput.Text   );
            if (player == null)
            {
                errorLabel.Show();
            }
            else
            {
                errorLabel.Hide();
            }
            (Parent as PlayerPanel).CurrentPlayer = player;
            passwordInput.Clear();
        }
    }
}
