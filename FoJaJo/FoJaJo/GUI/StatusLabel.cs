using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FoJaJo.GUI
{
    public class StatusLabel : Label
    {
        public void ShowStatus(String status)
        {
            ForeColor = Color.Green;
            Text = status;
            Refresh();
        }

        public void ShowException(Exception e)
        {
            ForeColor = Color.Red;
            Text = "error";
            Refresh();
        }
    }
}
