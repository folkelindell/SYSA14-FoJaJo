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
        private GameController gameController;
        public GameBoardControl()
        {
            InitializeComponent();
        }
    }
}
