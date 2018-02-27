using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;
using FoJaJo.Controller;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using FoJaJo.DAL;

namespace FoJaJo
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FoJaJo.GUI.RootForm());

        }
    }
}
