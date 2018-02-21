using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FoJaJo.GUI
{
    public partial class WebServiceOpenFile : UserControl
    {
        public WebServiceOpenFile()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string strFilePath = openFile.InitialDirectory + openFile.FileName;

                //System.IO.StreamReader sr = new System.IO.StreamReader(openFile.FileName);
                MessageBox.Show(strFilePath);
                //sr.Close();
            }
        }
    }
}
