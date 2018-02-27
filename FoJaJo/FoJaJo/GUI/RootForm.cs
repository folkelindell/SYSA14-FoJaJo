using FoJaJo.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoJaJo.GUI
{
    public partial class RootForm : Form
    {
        public RootController Controller { get; set; }
        public RootForm()
        {
            InitializeComponent();
            Controller = new RootController(this);
            luffarRootControl1.Controller = new GameController();
        }
    }
}
