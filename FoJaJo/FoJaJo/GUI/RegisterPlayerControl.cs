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
    public partial class RegisterPlayerControl : UserControl
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
            }
        }
        public RegisterPlayerControl()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            (Parent as PlayerPanel).ShowRegisterPlayer = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                controller.RegisterPlayer(usernameValue.Text, emailValue.Text, passwordValue.Text);
                Status.ShowStatus(usernameValue.Text + " has been registered.");
                usernameValue.Clear();
                emailValue.Clear();
                passwordValue.Clear();
                (Parent as PlayerPanel).ShowRegisterPlayer = false;
            }
            catch (Exception ex)
            {
                Status.ShowException(ex);
            }
        }
    }
}
